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

namespace Microsoft.Azure.Commands.LogicApp.Cmdlets
{
    using System.Management.Automation;
    using Microsoft.Azure.Commands.LogicApp.Utilities;
    using Microsoft.Azure.Management.Logic.Models;
    using Microsoft.Rest.Azure;
    using ResourceManager.Common.ArgumentCompleters;

    /// <summary>
    /// Gets the integration account certificate by name.
    /// </summary>
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "IntegrationAccountCertificate")]
    [OutputType(typeof(IntegrationAccountCertificate))]
    public class GetAzureIntegrationAccountCertificateCommand : LogicAppBaseCmdlet
    {

        #region Input Parameters

        [Parameter(Mandatory = false, HelpMessage = "The integration account resource group name.",
            ValueFromPipelineByPropertyName = true)]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "The integration account name.")]
        [ValidateNotNullOrEmpty]
        [Alias("IntegrationAccountName", "ResourceName")]
        public string Name { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "The integration account certificate name.")]
        [ValidateNotNullOrEmpty]
        public string CertificateName { get; set; }

        #endregion Input Parameters

        /// <summary>
        /// Executes the get integration account certificate command.
        /// </summary>
        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            if (string.IsNullOrEmpty(this.CertificateName))
            {
                this.WriteObject(IntegrationAccountClient.ListIntegrationAccountCertificates(this.ResourceGroupName, this.Name), true);
            }
            else
            {
                this.WriteObject(IntegrationAccountClient.GetIntegrationAccountCertifcate(this.ResourceGroupName, this.Name, this.CertificateName), true);
            }
        }
    }
}
