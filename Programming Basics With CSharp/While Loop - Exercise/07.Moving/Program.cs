using System;

namespace _07.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            string command = null;
            int sumCubicMeters = 0;

            while (command != "Done")
            {
                command = Console.ReadLine();
                if (command == "Done")
                {
                    Console.WriteLine($"{(width * lenght * height) - sumCubicMeters} Cubic meters left.");
                    break;
                }
                sumCubicMeters = sumCubicMeters + int.Parse(command);
                if (sumCubicMeters > (width * lenght * height))
                {
                    Console.WriteLine($"No more free space! You need {sumCubicMeters - (width * lenght * height)} Cubic meters more.");
                    break;
                }
            }
        }
    }
}
