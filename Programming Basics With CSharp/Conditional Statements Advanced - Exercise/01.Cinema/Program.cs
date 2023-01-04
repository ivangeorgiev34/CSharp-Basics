using System;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double total = 0.0;

            switch (projectionType)
            {
                case "Premiere":
                    total = 12 * rows * columns;
                    break;
                case "Normal":
                    total = 7.5 * rows * columns;
                    break;
                case "Discount":
                    total = 5 * rows * columns;
                    break;

            }
            Console.WriteLine($"{total:F2} leva");
        }
    }
}
