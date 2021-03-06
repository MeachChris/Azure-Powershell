// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Management.Automation;
using Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets.Models;
using Microsoft.Azure.Commands.RecoveryServices.Backup.Properties;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;

namespace Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets
{
    /// <summary>
    /// Deletes an existing protection policy from the recovery services vault
    /// </summary>
    [Cmdlet("Remove", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "RecoveryServicesBackupProtectionPolicy", SupportsShouldProcess = true,DefaultParameterSetName = PolicyNameParameterSet), OutputType(typeof(PolicyBase))]
    public class RemoveAzureRmRecoveryServicesBackupProtectionPolicy : RSBackupVaultCmdletBase
    {
        internal const string PolicyNameParameterSet = "PolicyName";
        internal const string PolicyObjectParameterSet = "PolicyObject";

        /// <summary>
        /// Name of the policy to be deleted
        /// </summary>
        [Parameter(Position = 1, Mandatory = true, HelpMessage = ParamHelpMsgs.Policy.Name,
            ParameterSetName = PolicyNameParameterSet)]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        /// <summary>
        /// Policy object to be deleted
        /// </summary>
        [Parameter(Position = 1, Mandatory = true, HelpMessage = ParamHelpMsgs.Policy.ProtectionPolicy,
            ValueFromPipeline = true,
            ParameterSetName = PolicyObjectParameterSet)]
        [ValidateNotNullOrEmpty]
        public PolicyBase Policy { get; set; }

        /// <summary>
        /// Return the policy to be deleted
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "Return the policy to be deleted.")]
        public SwitchParameter PassThru { get; set; }

        /// <summary>
        /// When provided, force delete policy, without asking for user confirmation
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = ParamHelpMsgs.Common.ConfirmationMessage)]
        public SwitchParameter Force { get; set; }

        private string PolicyName = string.Empty;

        public override void ExecuteCmdlet()
        {
            PolicyName = (this.ParameterSetName == PolicyNameParameterSet) ? Name : Policy.Name;
            if (string.IsNullOrEmpty(PolicyName))
            {
                throw new ArgumentException(Resources.PolicyNameIsEmptyOrNull);
            }

            ExecutionBlock(() =>
            {
                ConfirmAction(
                    Force.IsPresent,
                    string.Format(Resources.RemoveProtectionPolicyWarning, PolicyName),
                    Resources.RemoveProtectionPolicyMessage,
                    PolicyName, () =>
                    {
                        base.ExecuteCmdlet();

                        ResourceIdentifier resourceIdentifier = new ResourceIdentifier(VaultId);
                        string vaultName = resourceIdentifier.ResourceName;
                        string resourceGroupName = resourceIdentifier.ResourceGroupName;

                        WriteDebug(Resources.MakingClientCall);

                        ServiceClientAdapter.RemoveProtectionPolicy(
                            PolicyName,
                            vaultName: vaultName,
                            resourceGroupName: resourceGroupName);
                        WriteDebug(Resources.ProtectionPolicyDeleted);
                    }
                );

                if (PassThru.IsPresent)
                {
                    WriteObject(Policy);
                }
            }, ShouldProcess(PolicyName, VerbsCommon.Remove));
        }
    }
}
