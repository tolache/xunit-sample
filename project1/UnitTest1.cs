using System;
using Xunit;

namespace project1
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }

        [Fact]
        public void FrameworkDependentTest()
        {
            Assert.Equal(".NETCoreApp,Version=v1.0", GetFramework());
        }

        string GetFramework()
        {
            return AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName;
        }
    }
}
