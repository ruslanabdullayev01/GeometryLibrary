using GeometryLibrary.Enums;
using GeometryLibrary.Models;

namespace GeometryLibrary
{
    public class GeometryCalculator
    {
        #region Circle
        public static double CalculateCircleArea(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным числом.");
            }

            return Math.PI * radius * radius;
        }
        #endregion

        #region Triangle
        public static double CalculateTriangleArea(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("Длины сторон треугольника должны быть положительными числами.");
            }

            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }
        #endregion

        #region IsRightTriangle
        public static bool IsRightTriangle(double side1, double side2, double side3)
        {
            double side1Squared = side1 * side1;
            double side2Squared = side2 * side2;
            double side3Squared = side3 * side3;

            return side1Squared + side2Squared == side3Squared ||
                   side1Squared + side3Squared == side2Squared ||
                   side2Squared + side3Squared == side1Squared;
        }
        #endregion

        #region Random Shape
        public static double CalculateArea(Shape shape)
        {
            switch (shape.Type)
            {
                case ShapeType.Circle:
                    var circleData = (Circle)shape.Data;
                    return CalculateCircleArea(circleData.Radius);
                case ShapeType.Triangle:
                    var triangleData = (Triangle)shape.Data;
                    return CalculateTriangleArea(triangleData.Side1, triangleData.Side2, triangleData.Side3);
                default:
                    throw new ArgumentException("Неизвестный тип фигуры.");
            }
        }
        #endregion
    }
}
