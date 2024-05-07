using GeometryLibrary.Enums;
using GeometryLibrary.Models;
using GeometryLibrary;

#region Circle
double circleRadius = 3;
double circleArea = GeometryCalculator.CalculateCircleArea(circleRadius);

Console.WriteLine($"Площадь круга с радиусом {circleRadius} равна {circleArea}");
#endregion

#region Triangle
double side1 = 3;
double side2 = 4;
double side3 = 5;
double triangleArea = GeometryCalculator.CalculateTriangleArea(side1, side2, side3);
Console.WriteLine($"Площадь треугольника с сторонами {side1}, {side2}, {side3} равна {triangleArea}");

bool isRightTriangle = GeometryCalculator.IsRightTriangle(side1, side2, side3);
Console.WriteLine($"Треугольник с сторонами {side1}, {side2}, {side3} является прямоугольным: {isRightTriangle}");
#endregion

#region Random Shape
Shape circleShape = new Shape
{
    Type = ShapeType.Circle,
    Data = new Circle { Radius = 3 }
};
double circleShapeArea = GeometryCalculator.CalculateArea(circleShape);
Console.WriteLine($"Площадь фигуры (круг) равна {circleShapeArea}");

Shape triangleShape = new Shape
{
    Type = ShapeType.Triangle,
    Data = new Triangle { Side1 = 6, Side2 = 8, Side3 = 10 }
};
double triangleShapeArea = GeometryCalculator.CalculateArea(triangleShape);
Console.WriteLine($"Площадь фигуры (треугольник) равна {triangleShapeArea}");
#endregion