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

namespace Microsoft.Azure.Commands.DeploymentManager.Models
{
    using System;
    using Microsoft.Azure.Management.DeploymentManager.Models;

    public class PSBaseOperationInfo
    {
        public PSBaseOperationInfo(
            DateTime? startTime,
            DateTime? endTime,
            DateTime? lastUpdateTime,
            CloudErrorBody error)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.LastUpdatedTime = lastUpdateTime;
            this.Error = error;
        }

        public DateTime? StartTime
		{
			get;
			private set;
		}

		public DateTime? EndTime
		{
			get;
			private set;
		}

		public DateTime? LastUpdatedTime
		{
			get;
			private set;
		}

		public CloudErrorBody Error
		{
			get;
			set;
		}
    }
}
