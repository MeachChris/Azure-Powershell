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

using Microsoft.Azure.Commands.Common.Authentication;
using System;
using System.Collections.Generic;

namespace Microsoft.WindowsAzure.Commands.Common.Test.Mocks
{
    public class MockAccessToken : IRenewableToken
    {
        private string _tenantId = String.Empty;
        public void AuthorizeRequest(Action<string, string> authTokenSetter)
        {
            authTokenSetter("Bearer", AccessToken);
        }

        public string AccessToken { get; set; }
        public string UserId { get; set; }
        public string LoginType { get; set; }

        public string TenantId
        {
            get { return _tenantId; }
            set { _tenantId = value; }
        }

        public DateTimeOffset ExpiresOn { get; set; }

        public string HomeAccountId => throw new NotImplementedException();

        public IDictionary<string, string> ExtendedProperties => throw new NotImplementedException();
    }
}
