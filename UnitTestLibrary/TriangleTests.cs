using System;
using Xunit;

namespace TestTaskLibrary.UTests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(new[] { 5, 7, 10 }, 264)]
        [InlineData(new[] { 10, 10, 10 }, 1875)]
        public void CalculateSquareTest(int[] args, double expected)
        {
            //Arrange
            var triangle = new Triangle(args[0], args[1], args[2]);
            var sqrtExpected = Math.Sqrt(expected);

            //Act
            var result = triangle.CalculateSquare();

            //Assert
            Assert.Equal(sqrtExpected, result);
        }

        [Theory]
        [InlineData(new[] { 3, 4, 5 }, true)]
        [InlineData(new[] { 3, 5, 5 }, false)]
        public void SquarenessCheckTest(int[] args, bool expected)
        {
            //Arrange
            var triangle = new Triangle(args[0], args[1], args[2]);

            //Act
            var result = triangle.SquarenessCheck(args[0], args[1], args[2]);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}