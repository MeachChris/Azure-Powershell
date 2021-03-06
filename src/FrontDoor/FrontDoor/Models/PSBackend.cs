// ----------------------------------------------------------------------------------
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

namespace Microsoft.Azure.Commands.FrontDoor.Models
{
    public class PSBackend
    {
        public string Address { get; set; }

        public int? HttpPort { get; set; }

        public int? HttpsPort { get; set; }

        public int? Priority { get; set; }

        public int? Weight { get; set; }

        public string BackendHostHeader { get; set; }

        public PSEnabledState? EnabledState { get; set; }

        public string PrivateLinkAlias { get; set; }

        public string PrivateLinkResourceId { get; set; }

        public string PrivateLinkLocation { get; set; }

        public PSPrivateEndpointStatus? PrivateEndpointStatus { get; set; }

        public string PrivateLinkApprovalMessage { get; set; }
    }

    public enum PSPrivateEndpointStatus
    {
        Pending,
        Approved,
        Rejected,
        Disconnected,
        Timeout
    }
}
