using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double holidayMoney = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double numOfToys = puzzles + dolls + bears + minions + trucks;
            double sumOfToys = puzzles * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;
            double profit = 0;

            if (numOfToys >= 50)
            {
                sumOfToys -= (sumOfToys * 0.25);
                profit = sumOfToys - (sumOfToys * 0.10);

            }
            else
            {
                profit = sumOfToys - (sumOfToys * 0.10);
            }
            if (profit >= holidayMoney)
            {
                Console.WriteLine($"Yes! {(profit - holidayMoney):F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(holidayMoney - profit):F2} lv needed.");
            }
        }
    }
}
