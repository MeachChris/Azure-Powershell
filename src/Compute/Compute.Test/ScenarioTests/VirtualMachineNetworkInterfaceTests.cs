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

using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;

namespace Microsoft.Azure.Commands.Compute.Test.ScenarioTests
{
    public class VirtualMachineNetworkInterfaceTests : ComputeTestRunner
    {
        public VirtualMachineNetworkInterfaceTests(Xunit.Abstractions.ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestVirtualMachineSingleNetworkInterface()
        {
            TestRunner.RunTestScript("Test-SingleNetworkInterface");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestVirtualMachineMultipleNetworkInterface()
        {
            TestRunner.RunTestScript("Test-MultipleNetworkInterface");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSingleNetworkInterfaceDnsSettings()
        {
            TestRunner.RunTestScript("Test-SingleNetworkInterfaceDnsSettings");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestAddNetworkInterface()
        {
            TestRunner.RunTestScript("Test-AddNetworkInterface");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestEffectiveRoutesAndNsg()
        {
            TestRunner.RunTestScript("Test-EffectiveRoutesAndNsg");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSingleNetworkInterfaceWithAcceleratedNetworking()
        {
            TestRunner.RunTestScript("Test-SingleNetworkInterfaceWithAcceleratedNetworking");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestVMNicWithAcceleratedNetworkingValidations()
        {
            TestRunner.RunTestScript("Test-VMNicWithAcceleratedNetworkingValidations");
        }
    }
}
