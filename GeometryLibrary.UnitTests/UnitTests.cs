using GeometryLibrary.Enums;
using GeometryLibrary.Models;

namespace GeometryLibrary.UnitTests
{
    public class UnitTests
    {
        #region Circle
        [Fact]
        public void CalculateCircleArea_WithValidRadius_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 3;
            double expectedArea = 28.2743;

            // Act
            double actualArea = GeometryCalculator.CalculateCircleArea(radius);

            // Assert
            Assert.Equal(expectedArea, actualArea, 4);
        }
        #endregion

        #region Triangle
        [Fact]
        public void CalculateTriangleArea_WithValidSides_ReturnsCorrectArea()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double expectedArea = 6;

            // Act
            double actualArea = GeometryCalculator.CalculateTriangleArea(side1, side2, side3);

            // Assert
            Assert.Equal(expectedArea, actualArea, 4);
        }
        #endregion

        #region IsRightTriangle
        [Fact]
        public void IsRightTriangle_WithValidSides_ReturnsTrue()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;

            // Act
            bool isRightTriangle = GeometryCalculator.IsRightTriangle(side1, side2, side3);

            // Assert
            Assert.True(isRightTriangle);
        }
        #endregion

        #region Random Shape
        [Fact]
        public void CalculateArea_WithCircleShape_ReturnsCorrectArea()
        {
            // Arrange
            Shape circleShape = new Shape
            {
                Type = ShapeType.Circle,
                Data = new Circle { Radius = 3 }
            };
            double expectedArea = 28.2743;

            // Act
            double actualArea = GeometryCalculator.CalculateArea(circleShape);

            // Assert
            Assert.Equal(expectedArea, actualArea, 4);
        }

        [Fact]
        public void CalculateArea_WithTriangleShape_ReturnsCorrectArea()
        {
            // Arrange
            Shape triangleShape = new Shape
            {
                Type = ShapeType.Triangle,
                Data = new Triangle { Side1 = 3, Side2 = 4, Side3 = 5 }
            };
            double expectedArea = 6;

            // Act
            double actualArea = GeometryCalculator.CalculateArea(triangleShape);

            // Assert
            Assert.Equal(expectedArea, actualArea, 4);
        }
        #endregion
    }
}
