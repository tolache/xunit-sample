using Xunit;

namespace project1
{
    public class ParameterizedTests
    {
        private bool IsOddNumber(int number)
        {
            return number % 2 != 0;
        }

        [Theory]
        [InlineData(5, 1, 3, "a: 5, b: 8)")]
        [InlineData(7, 1, 5, "b")]
        public void AllNumbers_AreOdd_WithInlineData(int a, int b, int c, string d)
        {
            Assert.True(IsOddNumber(a));
            Assert.True(IsOddNumber(b));
            Assert.True(IsOddNumber(c));
            Assert.True(false, d);
        }         
    }
}