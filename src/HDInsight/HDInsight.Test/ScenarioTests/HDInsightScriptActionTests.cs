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

using Microsoft.Azure.ServiceManagement.Common.Models;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Commands.HDInsight.Test.ScenarioTests
{
    public class HDInsightScriptActionTests
    {
        public XunitTracingInterceptor _logger;

        public HDInsightScriptActionTests(ITestOutputHelper output)
        {
            _logger = new XunitTracingInterceptor(output);
            XunitTracingInterceptor.AddToContext(_logger);
        }

        [Fact(Skip="test case cannot be re-recorded properly, need help from service team")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestScriptActionRelatedCommands()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, "Test-ScriptActionRelatedCommands");
        }
    }
}
