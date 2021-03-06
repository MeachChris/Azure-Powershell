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

using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Management.Network;
using System.Collections.Generic;
using System.Management.Automation;
using Microsoft.Azure.Management.Network.Models;
using Microsoft.Rest.Azure;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VirtualNetwork"), OutputType(typeof(PSVirtualNetwork))]
    public class GetAzureVirtualNetworkCommand : VirtualNetworkBaseCmdlet
    {
        [Alias("ResourceName")]
        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource name.",
            ParameterSetName = "NoExpand")]
        [Parameter(
           Mandatory = true,
           ValueFromPipelineByPropertyName = true,
           HelpMessage = "The resource name.",
           ParameterSetName = "Expand")]
        [ResourceNameCompleter("Microsoft.Network/virtualNetworks", "ResourceGroupName")]
        [ValidateNotNullOrEmpty]
        [SupportsWildcards]
        public virtual string Name { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource group name.",
            ParameterSetName = "NoExpand")]
        [Parameter(
           Mandatory = true,
           ValueFromPipelineByPropertyName = true,
           HelpMessage = "The resource group name.",
           ParameterSetName = "Expand")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        [SupportsWildcards]
        public virtual string ResourceGroupName { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource reference to be expanded.",
            ParameterSetName = "Expand")]
        [ValidateNotNullOrEmpty]
        public string ExpandResource { get; set; }

        public override void Execute()
        {

            base.Execute();
            if (ShouldGetByName(ResourceGroupName, Name))
            {
                var vnet = this.GetVirtualNetwork(this.ResourceGroupName, this.Name, this.ExpandResource);

                WriteObject(vnet);
            }
            else
            {
                IPage<Microsoft.Azure.Management.Network.Models.VirtualNetwork> vnetPage;
                if (ShouldListByResourceGroup(ResourceGroupName, Name))
                {
                    vnetPage = this.VirtualNetworkClient.List(this.ResourceGroupName);
                }
                else
                {
                    vnetPage = this.VirtualNetworkClient.ListAll();
                }

                // Get all resources by polling on next page link
                var vnetList = ListNextLink<Microsoft.Azure.Management.Network.Models.VirtualNetwork>.GetAllResourcesByPollingNextLink(vnetPage, this.VirtualNetworkClient.ListNext);

                var psVnets = new List<PSVirtualNetwork>();
                foreach (var virtualNetwork in vnetList)
                {
                    var psVnet = this.ToPsVirtualNetwork(virtualNetwork);
                    psVnet.ResourceGroupName = NetworkBaseCmdlet.GetResourceGroup(virtualNetwork.Id);
                    psVnets.Add(psVnet);
                }

                WriteObject(TopLevelWildcardFilter(ResourceGroupName, Name, psVnets), true);
            }
        }
    }
}
