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
    using System;
    using System.Management.Automation;

    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ApiManagementSubscription", DefaultParameterSetName = GetAll)]
    [OutputType(typeof(PsApiManagementSubscription), ParameterSetName = new[] { GetAll, GetBySubscriptionId, GetByUserId, GetByScope, GetByProductIdAndUser, GetByProductId })]
    public class GetAzureApiManagementSubscription : AzureApiManagementCmdletBase
    {
        private const string GetAll = "GetAllSubscriptions";
        private const string GetBySubscriptionId = "GetBySubscriptionId";
        private const string GetByUserId = "GetByUserId";
        private const string GetByScope = "GetByScope";
        private const string GetByProductId = "GetByProductId";
        private const string GetByProductIdAndUser = "GetByProductIdAndUser";

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true,
            Mandatory = true,
            HelpMessage = "Instance of PsApiManagementContext. This parameter is required.")]
        [ValidateNotNullOrEmpty]
        public PsApiManagementContext Context { get; set; }

        [Parameter(
            ParameterSetName = GetBySubscriptionId,
            ValueFromPipelineByPropertyName = true,
            Mandatory = false,
            HelpMessage = "Subscription identifier. If specified will try to find subscription by the identifier. This parameter is optional.")]
        public String SubscriptionId { get; set; }

        [Parameter(
            ParameterSetName = GetByProductIdAndUser,
            ValueFromPipelineByPropertyName = true,
            Mandatory = true,
            HelpMessage = "User identifier. If specified will try to find all subscriptions by the user identifier. This parameter is optional.")]
        [Parameter(
            ParameterSetName = GetByUserId,
            ValueFromPipelineByPropertyName = true,
            Mandatory = false,
            HelpMessage = "User identifier. If specified will try to find all subscriptions by the user identifier. This parameter is optional.")]
        public String UserId { get; set; }

        [Parameter(
            ParameterSetName = GetByProductIdAndUser,
            ValueFromPipelineByPropertyName = true,
            Mandatory = true,
            HelpMessage = "Product identifier. If specified will try to find all subscriptions by the product identifier. This parameter is optional.")]
        [Parameter(
            ParameterSetName = GetByProductId,
            ValueFromPipelineByPropertyName = true,
            Mandatory = false,
            HelpMessage = "Product identifier. If specified will try to find all subscriptions by the product identifier. This parameter is optional.")]
        public String ProductId { get; set; }

        [Parameter(
            ParameterSetName = GetByScope,
            ValueFromPipelineByPropertyName = true,
            Mandatory = true,
            HelpMessage = "Scope identifier. The Scope of the Subscription, whether it is Api Scope /apis/{apiId} or Product Scope /products/{productId} or Global API Scope /apis or Global scope /.")]
        public String Scope { get; set; }

        public override void ExecuteApiManagementCmdlet()
        {
            if (ParameterSetName.Equals(GetAll))
            {
                var subscriptions = Client.SubscriptionList(Context);
                WriteObject(subscriptions, true);
            }
            else if (ParameterSetName.Equals(GetBySubscriptionId))
            {
                var subscription = Client.SubscriptionById(
                    Context.ResourceGroupName, 
                    Context.ServiceName,
                    SubscriptionId);
                WriteObject(subscription);
            }
            else if (ParameterSetName.Equals(GetByProductId))
            {
                var subscriptions = Client.SubscriptionByProduct(Context, ProductId);
                WriteObject(subscriptions, true);
            }
            else if (ParameterSetName.Equals(GetByUserId))
            {
                var subscriptions = Client.SubscriptionByUser(Context, UserId);
                WriteObject(subscriptions, true);
            }
            else if (ParameterSetName.Equals(GetByScope))
            {
                var subscriptions = Client.SubscriptionByScope(Context, Scope);
                WriteObject(subscriptions, true);
            }
            else if (ParameterSetName.Equals(GetByProductIdAndUser))
            {
                var subscriptions = Client.SubscriptionByProductAndUser(Context, ProductId, UserId);
                WriteObject(subscriptions, true);
            }
            else
            {
                throw new InvalidOperationException(string.Format("Parameter set name '{0}' is not supported.", ParameterSetName));
            }
        }
    }
}
