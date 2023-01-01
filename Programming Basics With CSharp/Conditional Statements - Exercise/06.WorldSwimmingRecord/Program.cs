using System;

namespace _06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double meterInTime = double.Parse(Console.ReadLine());
            double timeIvan = lenght * meterInTime;
            double resistence = Math.Floor(lenght / 15) * 12.5;
            double totalTimeIvan = timeIvan + resistence;
            if (totalTimeIvan < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTimeIvan:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTimeIvan - record:F2} seconds slower.");
            }
        }
    }
}
