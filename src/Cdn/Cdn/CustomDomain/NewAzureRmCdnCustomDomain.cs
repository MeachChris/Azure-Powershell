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
using System.IO;
using System.Management.Automation;
using System.Net;
using System.Reflection;
using Microsoft.Azure.Commands.Cdn.Common;
using Microsoft.Azure.Commands.Cdn.Helpers;
using Microsoft.Azure.Commands.Cdn.Models.CustomDomain;
using Microsoft.Azure.Commands.Cdn.Properties;
using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Management.Cdn;
using Microsoft.Azure.Management.Cdn.Models;
using Microsoft.Azure.Commands.Cdn.Models.Endpoint;
using System.Linq;
using Microsoft.WindowsAzure.Commands.Common;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;

namespace Microsoft.Azure.Commands.Cdn.CustomDomain
{
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "CdnCustomDomain", DefaultParameterSetName = FieldsParameterSet, SupportsShouldProcess = true), OutputType(typeof(PSCustomDomain))]
    public class NewAzureRmCdnCustomDomain : AzureCdnCmdletBase
    {
        [Parameter(Mandatory = true, HelpMessage = "Host name (address) of the Azure CDN custom domain name.")]
        [ValidateNotNullOrEmpty]
        public string HostName { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "Azure CDN custom domain display name.")]
        [ValidateNotNullOrEmpty]
        public string CustomDomainName { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "Azure CDN endpoint name.", ParameterSetName = FieldsParameterSet)]
        [ValidateNotNullOrEmpty]
        public string EndpointName { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "Azure CDN profile name.", ParameterSetName = FieldsParameterSet)]
        [ValidateNotNullOrEmpty]
        public string ProfileName { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "The resource group of the Azure CDN profile.", ParameterSetName = FieldsParameterSet)]
        [ResourceGroupCompleter()]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipeline = true, HelpMessage = "The CDN endpoint object.", ParameterSetName = ObjectParameterSet)]
        [ValidateNotNull]
        public PSEndpoint CdnEndpoint { get; set; }

        public override void ExecuteCmdlet()
        {

            if (ParameterSetName == ObjectParameterSet)
            {
                ResourceGroupName = CdnEndpoint.ResourceGroupName;
                ProfileName = CdnEndpoint.ProfileName;
                EndpointName = CdnEndpoint.Name;
            }

            var existingCustomDomain = CdnManagementClient.CustomDomains
                .ListByEndpoint(ResourceGroupName, ProfileName, EndpointName)
                .FirstOrDefault(cd => cd.Name.ToLower() == CustomDomainName.ToLower());

            if (existingCustomDomain != null)
            {
                throw new PSArgumentException(string.Format(
                    Resources.Error_CreateExistingCustomDomain,
                    CustomDomainName,
                    EndpointName,
                    ProfileName,
                    ResourceGroupName));
            }

            ConfirmAction(MyInvocation.InvocationName,
                HostName,
                NewCustomDomain);
        }

        private void NewCustomDomain()
        {
            var customDomain = CdnManagementClient.CustomDomains.Create(
                ResourceGroupName,
                ProfileName,
                EndpointName,
                CustomDomainName,
                HostName);

            WriteVerbose(Resources.Success);
            WriteObject(customDomain.ToPsCustomDomain());
        }
    }
}
