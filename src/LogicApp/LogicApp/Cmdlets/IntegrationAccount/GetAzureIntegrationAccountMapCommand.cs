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
    /// Gets the integration account map
    /// </summary>
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "IntegrationAccountMap")]
    [OutputType(typeof(IntegrationAccountMap))]
    public class GetAzureIntegrationAccountMapCommand : LogicAppBaseCmdlet
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

        [Parameter(Mandatory = false, HelpMessage = "The integration account map name.")]
        [ValidateNotNullOrEmpty]
        public string MapName { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "The integration account map type.")]
        [ValidateNotNullOrEmpty]
        [PSArgumentCompleter("Xslt", "Xslt20", "Xslt30", "Liquid")]
        public string MapType { get; set; }

        #endregion Input Parameters

        /// <summary>
        /// Executes the get integration account map command.
        /// </summary>
        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();

            if (string.IsNullOrEmpty(this.MapName))
            {
                this.WriteObject(IntegrationAccountClient.ListIntegrationAccountMaps(this.ResourceGroupName,this.Name, this.MapType), true);
            }
            else
            {
                this.WriteObject(IntegrationAccountClient.GetIntegrationAccountMap(this.ResourceGroupName, this.Name, this.MapName), true);
            }
        }
    }
}
