using Microsoft.Azure.Commands.ScenarioTest;
using Microsoft.Azure.ServiceManagement.Common.Models;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.Test.Utilities.Common;
using Xunit;
using Xunit.Abstractions;

namespace Commands.Aks.Test.ScenarioTests
{
    public class GetAksVersionTests : RMTestBase
    {
        XunitTracingInterceptor _logger;
        public GetAksVersionTests(ITestOutputHelper output)
        {
            _logger = new XunitTracingInterceptor(output);
            XunitTracingInterceptor.AddToContext(_logger);
            TestExecutionHelpers.SetUpSessionAndProfile();
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestAksVersion()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, "Test-GetAksVersion");
        }
    }
}
