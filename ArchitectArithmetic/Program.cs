using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            // calculate area of different shapes that make up structure
            double areaOfRectangle = Rectangle(2500, 1500);
            Console.WriteLine($"The area of the rectangle is {areaOfRectangle}");

            double areaOfCircle = 0.5 * Circle(375);
            Console.WriteLine($"The area of the circle is {areaOfCircle}");

            double areaOfTriangle = Triangle(750, 500);
            Console.WriteLine($"The area of the triangle is {areaOfTriangle}");

            double totalArea = areaOfRectangle + areaOfCircle + areaOfTriangle;
            Console.WriteLine($"Added all up, these are {totalArea}");

            //Costs are calculated here
            double costOfFlooring = Math.Round(totalArea * 180, 2);
            Console.WriteLine($"The total cost of flooring is {costOfFlooring} Pesos");
        }

        public static double Rectangle(double length, double width)
        {
            double area = length * width;
            return area;
        }

        public static double Circle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public static double Triangle(double bottom, double height)
        {
            double area = 0.5 * bottom * height;
            return area;
        }

    }
}
