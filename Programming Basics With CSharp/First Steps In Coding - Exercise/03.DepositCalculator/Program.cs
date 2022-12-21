using System;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositedSum = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine()) / 100;
            double totalSum = depositedSum + term * ((depositedSum * percentage) / 12);
            Console.WriteLine(totalSum);
        }
    }
}
