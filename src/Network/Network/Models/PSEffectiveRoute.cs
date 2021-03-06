//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

namespace Microsoft.Azure.Commands.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using WindowsAzure.Commands.Common.Attributes;

    public class PSEffectiveRoute
    {
        [JsonProperty(Order = 1)]
        [Ps1Xml(Target = ViewControl.Table)]
        public string Name { get; set; }

        [JsonProperty(Order = 1)]
        [Ps1Xml(Target = ViewControl.Table)]
        public bool DisableBgpRoutePropagation { get; set; }

        [JsonProperty(Order = 1)]
        [Ps1Xml(Target = ViewControl.Table)]
        public string State { get; set; }

        [JsonProperty(Order = 1)]
        [Ps1Xml(Target = ViewControl.Table)]
        public string Source { get; set; }

        [JsonProperty(Order = 1)]
        public List<string> AddressPrefix { get; set; }

        [JsonProperty(Order = 1)]
        [Ps1Xml(Target = ViewControl.Table)]
        public string NextHopType { get; set; }

        [JsonProperty(Order = 1)]
        public List<string> NextHopIpAddress { get; set; }        
    }
}
