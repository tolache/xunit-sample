using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
		[Trait("Category", "One")]
        public void Test1()
        {
        }

        [Theory]
		[Trait("Category", "One")]
        [InlineData("a")]
        [InlineData("b")]
        public void Test2(string str)
        {
        }
    }
	
	public class UnitTest2
    {
        [Fact]
		[Trait("Category", "Two")]
        public void Test1()
        {
        }

        [Theory]
		[Trait("Category", "Two")]
        [InlineData("a")]
        [InlineData("b")]
        public void Test2(string str)
        {
        }
    }
}