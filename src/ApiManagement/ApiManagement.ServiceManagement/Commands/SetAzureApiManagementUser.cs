//  
// Copyright (c) Microsoft.  All rights reserved.
// 
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
// 
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

namespace Microsoft.Azure.Commands.ApiManagement.ServiceManagement.Commands
{
    using Microsoft.Azure.Commands.ApiManagement.ServiceManagement.Models;
    using Microsoft.Azure.Commands.ApiManagement.ServiceManagement.Properties;
    using System;
    using System.Management.Automation;
    using System.Security;
    using WindowsAzure.Commands.Common;

    [Cmdlet("Set", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ApiManagementUser", SupportsShouldProcess = true)]
    [OutputType(typeof(PsApiManagementUser))]
    public class SetAzureApiManagementUser : AzureApiManagementCmdletBase
    {
        [Parameter(
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true,
            Mandatory = true,
            HelpMessage = "Instance of PsApiManagementContext. This parameter is required.")]
        [ValidateNotNullOrEmpty]
        public PsApiManagementContext Context { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            Mandatory = true,
            HelpMessage = "Identifier of existing user. This parameter is required. ")]
        [ValidateNotNullOrEmpty]
        public String UserId { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            Mandatory = false,
            HelpMessage = "User first name. This parameter is optional. Must be 1 to 100 characters long.")]
        public String FirstName { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            Mandatory = false,
            HelpMessage = "User last name. This parameter is optional. Must be 1 to 100 characters long.")]
        public String LastName { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            Mandatory = false,
            HelpMessage = "User email. This parameter is optional.")]
        public String Email { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            Mandatory = false,
            HelpMessage = "User password. This parameter is optional.")]
        public SecureString Password { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            Mandatory = false,
            HelpMessage = "User state. This parameter is optional. Default value is Active.")]
        public PsApiManagementUserState State { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            Mandatory = false,
            HelpMessage = "Note on the user. This parameter is optional. Default value is $null.")]
        public String Note { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            Mandatory = false,
            HelpMessage = "If specified then instance of " +
                          "Microsoft.Azure.Commands.ApiManagement.ServiceManagement.Models.PsApiManagementUser type" +
                          " representing the modified user.")]
        public SwitchParameter PassThru { get; set; }

        public override void ExecuteApiManagementCmdlet()
        {
            if (ShouldProcess(UserId, Resources.SetUser))
            {
                Client.UserSet(Context, UserId, FirstName, LastName, Password != null ? Password.ConvertToString() : null, Email, State, Note);

                if (PassThru)
                {
                    var user = Client.UserById(Context, UserId);
                    WriteObject(user);
                }
            }
        }
    }
}
