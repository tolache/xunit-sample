using System;
using Xunit;

namespace project2
{
    public class UnitTest1
    {
        [Fact]
        [Trait("Disabled","False")]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
