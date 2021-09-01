using Xunit;

namespace TestTaskLibrary.UTests
{
    public class CircleTests
    {
        [Fact]
        public void CalculateSquareTest()
        {
            //Arrange
            var circle = new Circle(10);

            //Act
            var result = circle.CalculateSquare();

            //Assert
            Assert.Equal(314, result);
        }
    }
}