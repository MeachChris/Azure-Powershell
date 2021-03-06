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

using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Cdn.Common;
using Microsoft.Azure.Commands.Cdn.Helpers;
using Microsoft.Azure.Commands.Cdn.Models.Profile;
using Microsoft.Azure.Commands.Cdn.Properties;
using Microsoft.Azure.Management.Cdn;
using System;
using System.Net;
using Microsoft.Azure.Management.Cdn.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;

namespace Microsoft.Azure.Commands.Cdn.Profile
{
    /// <summary>
    /// Defines the New-AzCdnProfile cmdlet.
    /// </summary>
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "CdnProfile"), OutputType(typeof(PSProfile))]
    public class GetAzureRmCdnProfile : AzureCdnCmdletBase
    {
        /// <summary>
        /// Gets or sets the profile name.
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "Azure CDN profile name.")]
        [ValidateNotNullOrEmpty]
        public string ProfileName { get; set; }

        /// <summary>
        /// The resource group name of the profile.
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "The resource group of the Azure CDN profile.")]
        [ResourceGroupCompleter()]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }


        public override void ExecuteCmdlet()
        {
            if (ProfileName == null && ResourceGroupName == null)
            {
                // List by subscription.
                var profiles = CdnManagementClient.Profiles.List()
                               .Where(profile => (profile.Sku.Name != "Premium_AzureFrontDoor") && (profile.Sku.Name != "Standard_AzureFrontDoor"))
                               .Select(profile => profile.ToPsProfile());

                WriteVerbose(Resources.Success);
                WriteObject(profiles, true);
            }
            else if (ProfileName == null && ResourceGroupName != null)
            {
                // List by Resource Group name.
                var profiles = CdnManagementClient.Profiles.ListByResourceGroup(ResourceGroupName)
                               .Where(profile => (profile.Sku.Name != "Premium_AzureFrontDoor") && (profile.Sku.Name != "Standard_AzureFrontDoor"))
                               .Select(profile => profile.ToPsProfile());

                WriteVerbose(Resources.Success);
                WriteObject(profiles.ToArray(), true);
            }
            else if (ProfileName != null && ResourceGroupName == null)
            {
                var profiles = CdnManagementClient.Profiles.List()
                               .Where(profile => (profile.Sku.Name != "Premium_AzureFrontDoor") && (profile.Sku.Name != "Standard_AzureFrontDoor"))
                               .Where(profile => profile.Name == this.ProfileName)
                               .Select(profile => profile.ToPsProfile());

                WriteVerbose(Resources.Success);
                WriteObject(profiles);
            }
            else
            {
                try
                {
                    // Get by both Profile Name and Resource Group Name.
                    var profile = CdnManagementClient.Profiles.Get(ResourceGroupName, ProfileName);
                    if ((profile.Sku.Name != "Premium_AzureFrontDoor") && (profile.Sku.Name != "Standard_AzureFrontDoor"))
                    {
                        WriteVerbose(Resources.Success);
                        WriteObject(profile.ToPsProfile());
                    }
                }
                catch(ErrorResponseException ex)
                {
                    if (ex.Response.StatusCode.Equals(HttpStatusCode.NotFound))
                    {
                        throw new PSArgumentException(string.Format(
                            Resources.Error_ProfileNotFound,
                            ProfileName,
                            ResourceGroupName));
                    }
                }
            }
        }
    }
}
