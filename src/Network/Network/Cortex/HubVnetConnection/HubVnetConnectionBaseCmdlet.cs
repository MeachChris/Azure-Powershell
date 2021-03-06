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

namespace Microsoft.Azure.Commands.Network
{
    using AutoMapper;
    using Microsoft.Azure.Commands.Network.Models;
    using Microsoft.Azure.Commands.ResourceManager.Common.Tags;
    using Microsoft.Azure.Management.Network;
    using System.Collections.Generic;
    using System.Net;
    using MNM = Microsoft.Azure.Management.Network.Models;

    public class HubVnetConnectionBaseCmdlet : NetworkBaseCmdlet
    {
        public IHubVirtualNetworkConnectionsOperations HubVirtualNetworkConnectionsClient
        {
            get
            {
                return NetworkClient.NetworkManagementClient.HubVirtualNetworkConnections;
            }
        }

        public PSHubVirtualNetworkConnection ToPsHubVirtualNetworkConnection(Management.Network.Models.HubVirtualNetworkConnection hubConnection)
        {
            var psVirtualHubVirtualNetworkConnection = NetworkResourceManagerProfile.Mapper.Map<PSHubVirtualNetworkConnection>(hubConnection);

            return psVirtualHubVirtualNetworkConnection;
        }

        public PSHubVirtualNetworkConnection CreateOrUpdateHubVirtualNetworkConnection(string resourceGroupName, string virtualHubName, string connectionName, MNM.HubVirtualNetworkConnection hubVirtualNetworkConnectionParameters,  Dictionary<string, List<string>> customHeaders = null)
        {
            MNM.HubVirtualNetworkConnection hubVnetConnCreated;

            if (customHeaders == null)
            {
                hubVnetConnCreated = this.HubVirtualNetworkConnectionsClient.CreateOrUpdate(resourceGroupName, virtualHubName, connectionName, hubVirtualNetworkConnectionParameters);
            }
            else
            {
                // Execute the create call and pass the custom headers. 
                using (var _result = this.HubVirtualNetworkConnectionsClient.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualHubName, connectionName, hubVirtualNetworkConnectionParameters, customHeaders).GetAwaiter().GetResult())
                {
                    hubVnetConnCreated = _result.Body;
                }
            }

            return this.ToPsHubVirtualNetworkConnection(hubVnetConnCreated);
        }

        public PSHubVirtualNetworkConnection GetHubVirtualNetworkConnection(string resourceGroupName, string virtualHubName, string name)
        {
            var virtualHubConnection = this.HubVirtualNetworkConnectionsClient.Get(resourceGroupName, virtualHubName, name);
            var psHubVirtualNetworkConnection = ToPsHubVirtualNetworkConnection(virtualHubConnection);

            return psHubVirtualNetworkConnection;
        }

        public List<PSHubVirtualNetworkConnection> ListHubVnetConnections(string resourceGroupName, string parentHubName)
        {
            var hubVnetConnections = this.HubVirtualNetworkConnectionsClient.List(resourceGroupName, parentHubName);

            List<PSHubVirtualNetworkConnection> connectionsToReturn = new List<PSHubVirtualNetworkConnection>();
            if (hubVnetConnections != null)
            {
                foreach (MNM.HubVirtualNetworkConnection connection in hubVnetConnections)
                {
                    connectionsToReturn.Add(ToPsHubVirtualNetworkConnection(connection));
                }
            }

            return connectionsToReturn;
        }

        public bool IsHubVnetConnectionPresent(string resourceGroupName, string parentHubName, string name)
        {
            return NetworkBaseCmdlet.IsResourcePresent(() => { GetHubVirtualNetworkConnection(resourceGroupName, parentHubName, name); });
        }
    }
}