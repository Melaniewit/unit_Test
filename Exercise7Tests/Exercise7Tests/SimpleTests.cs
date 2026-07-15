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

        [Theory]
        [InlineData(5,3,2)]
        [InlineData(6,3,3)]

        public void Sub_Two_Numbers(int arg1,int arg2, int arg3)
        {
            //Act
            var result=Calculator.Sub(arg1, arg2);


            //Assert
            Assert.Equal(arg3, result);

        }


    }
}
