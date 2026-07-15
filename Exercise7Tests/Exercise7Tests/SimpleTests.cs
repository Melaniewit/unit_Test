using Xunit;
using MathsLibrary;

namespace Exercise_Tests
{
    public class SimpleTests
    {
        [Fact]
        public void Add_Two_Numbers()
        {
            // Arrange
            var num1 = 5;
            var num2 = 2;
            var expectedValue = 7;

            // Act
            var sum = Calculator.Add(num1, num2);

            // Assert
            Assert.Equal(expectedValue, sum);
        }
    }
}
