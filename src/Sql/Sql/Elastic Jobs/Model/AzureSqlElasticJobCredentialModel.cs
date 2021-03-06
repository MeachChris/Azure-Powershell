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

using System.Security;

namespace Microsoft.Azure.Commands.Sql.ElasticJobs.Model
{
    /// <summary>
    /// Represents the core properties of a job credential
    /// </summary>
    public class AzureSqlElasticJobCredentialModel : AzureSqlElasticJobsBaseModel
    {
        /// <summary>
        /// Gets or sets the job credential name
        /// </summary>
        public string CredentialName { get; set; }

        /// <summary>
        /// Gets or sets the user name
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password
        /// </summary>
        public SecureString Password { get; set; }
    }
}