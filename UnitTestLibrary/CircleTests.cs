using System;
using Xunit;

namespace TestTaskLibrary.UTests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(10, Math.PI * 100)]
        [InlineData(2, Math.PI * 4)]
        [InlineData(15, Math.PI * 225)]
        public void CalculateSquareTest(int arg, double expected)
        {
            //Arrange
            var circle = new Circle(arg);

            //Act
            var result = circle.CalculateSquare();

            //Assert
            Assert.Equal(expected, result);
        }
    }
}