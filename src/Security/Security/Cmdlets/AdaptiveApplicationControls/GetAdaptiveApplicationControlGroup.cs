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
// ------------------------------------

using System.Management.Automation;
using Commands.Security;
using Microsoft.Azure.Commands.Security.Common;
using Microsoft.Azure.Commands.SecurityCenter.Models.AdaptiveApplicationControls;

namespace Microsoft.Azure.Commands.Security.Cmdlets.AdaptiveApplicationControls
{
    [Cmdlet(VerbsCommon.Get, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "SecurityAdaptiveApplicationControlGroup", DefaultParameterSetName = ParameterSetNames.ResourceGroupScope), OutputType(typeof(PSSecurityAdaptiveApplicationControls))]
    public class GetAdaptiveApplicationControlGroup : SecurityCenterCmdletBase
    {
        [Parameter(ParameterSetName = ParameterSetNames.ResourceGroupScope, Mandatory = true, HelpMessage = ParameterHelpMessages.AdaptiveApplicationControlsGroupName)]
        [ValidateNotNullOrEmpty]
        public string GroupName { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.ResourceGroupScope, Mandatory = true, HelpMessage = ParameterHelpMessages.AscLocation)]
        [ValidateNotNullOrEmpty]
        public string AscLocation { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.ResourceGroupScope, Mandatory = false, HelpMessage = ParameterHelpMessages.SubscriptionId)]
        [ValidateNotNullOrEmpty]
        public string SubscriptionId { get; set; }

        public override void ExecuteCmdlet()
        {
            SecurityCenterClient.AscLocation = AscLocation;
            SecurityCenterClient.SubscriptionId = SubscriptionId ?? SecurityCenterClient.SubscriptionId;

            var adaptiveApplicationControls = SecurityCenterClient.AdaptiveApplicationControls
                .GetWithHttpMessagesAsync(GroupName)
                .GetAwaiter()
                .GetResult()
                .Body;

            WriteObject(adaptiveApplicationControls.ConvertToPSType(), enumerateCollection: true);
        }
    }
}
