using System;

namespace _01.USDToBgn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyInUsd = double.Parse(Console.ReadLine());
            double moneyInBgn = moneyInUsd * 1.79549;
            Console.WriteLine(moneyInBgn);
        }
    }
}
