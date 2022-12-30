using System;

namespace _07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type one of the following: square, rectangle, circle, triangle");
            string figure = Console.ReadLine();

            //logic
            if (figure == "square")
            {
                double squareSide = double.Parse(Console.ReadLine());
                double squareArea = Math.Pow(squareSide, 2);
                Console.WriteLine($"{squareArea:F3}");
            }
            else if (figure == "rectangle")
            {
                double rectangleSide1 = double.Parse(Console.ReadLine());
                double rectangleSide2 = double.Parse(Console.ReadLine());
                double rectangleArea = rectangleSide1 * rectangleSide2;
                Console.WriteLine($"{rectangleArea:F3}");
            }
            else if (figure == "circle")
            {
                double circleRadius = double.Parse(Console.ReadLine());
                double circleArea = Math.Pow(circleRadius, 2) * (Math.PI);
                Console.WriteLine($"{circleArea:F3}");
            }
            else if (figure == "triangle")
            {
                double triangleSide = double.Parse(Console.ReadLine());
                double triangleHeight = double.Parse(Console.ReadLine());
                double triangleArea = (triangleSide * triangleHeight) / 2;
                Console.WriteLine($"{triangleArea:F3}");

            }
            else
            {
                Console.WriteLine("Invalid figure!");
            }
        }
    }
}
