using System;
using Xunit;
using Xunit.Abstractions;

namespace project1
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public UnitTest1(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        [Trait("Disabled","False")]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
            _testOutputHelper.WriteLine("##teamcity[testMetadata type='image' value='green.png']");
        }

        int Add(int x, int y)
        {
            return x + y;
        }
        
        [Fact]
        [Trait("Disabled","False")]
        public void FailingTest()
        {
            Assert.Equal(4, Add(2, 2));
            _testOutputHelper.WriteLine("##teamcity[testMetadata type='image' value='red.png']");
        }
    }
}
