using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    //Without DRY
    class DryPrinciple
    {
        static void Main()
        {
            double squareArea = CalculateSquareArea(5);
            Console.WriteLine($"Square area: {squareArea}");

            double rectangleArea = CalculateRectangleArea(4, 6);
            Console.WriteLine($"Rectangle area: {rectangleArea}");

            double circleArea = CalculateCircleArea(3);
            Console.WriteLine($"Circle area: {circleArea}");
        }

        // Calculate square area
        static double CalculateSquareArea(double side)
        {
            return side * side;
        }

        // Calculate rectangle area
        static double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }

        // Calculate circle area
        static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
    //With DRY
    enum ShapeType { Square, Rectangle, Circle }

    class Program44
    {
        static void Main()
        {
            double squareArea = CalculateArea(ShapeType.Square, 5);
            Console.WriteLine($"Square area: {squareArea}");

            double rectangleArea = CalculateArea(ShapeType.Rectangle, 4, 6);
            Console.WriteLine($"Rectangle area: {rectangleArea}");

            double circleArea = CalculateArea(ShapeType.Circle, 3);
            Console.WriteLine($"Circle area: {circleArea}");
        }

        static double CalculateArea(ShapeType shape, params double[] dimensions)
        {
            switch (shape)
            {
                case ShapeType.Square:
                    return dimensions[0] * dimensions[0];
                case ShapeType.Rectangle:
                    return dimensions[0] * dimensions[1];
                case ShapeType.Circle:
                    return Math.PI * dimensions[0] * dimensions[0];
                default:
                    throw new ArgumentException("Invalid shape type");
            }
        }
    }


}
