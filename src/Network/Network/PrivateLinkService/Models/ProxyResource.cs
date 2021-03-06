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

namespace Microsoft.Azure.Commands.Network.PrivateLinkService.Models
{
    /// <summary>
    /// ARM proxy resource.
    /// </summary>
    public partial class ProxyResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ProxyResource class.
        /// </summary>
        public ProxyResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProxyResource class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        public ProxyResource(string id = default(string), string name = default(string), string type = default(string))
            : base(id, name, type)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
