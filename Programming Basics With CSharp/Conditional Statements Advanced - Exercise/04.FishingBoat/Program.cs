using System;

namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int spring = 3000;
            const int summer = 4200;
            const int autumn = 4200;
            const int winter = 2600;
            const double discount = 0.05;

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double total = 0.0;

            switch (season)
            {
                case "Spring":
                    if (fishermen <= 6)
                    {
                        total = spring - (spring * 0.10);
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        total = spring - (spring * 0.15);
                    }
                    else if (fishermen >= 12)
                    {
                        total = spring - (spring * 0.25);
                    }
                    if (fishermen % 2 == 0)
                    {
                        total = total - (total * discount);
                    }
                    break;
                case "Summer":
                    if (fishermen <= 6)
                    {
                        total = summer - (summer * 0.10);
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        total = summer - (summer * 0.15);
                    }
                    else if (fishermen >= 12)
                    {
                        total = summer - (summer * 0.25);
                    }
                    if (fishermen % 2 == 0)
                    {
                        total = total - (total * discount);
                    }
                    break;
                case "Autumn":
                    if (fishermen <= 6)
                    {
                        total = autumn - (autumn * 0.10);
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        total = autumn - (autumn * 0.15);
                    }
                    else if (fishermen >= 12)
                    {
                        total = autumn - (autumn * 0.25);
                    }
                    break;
                case "Winter":
                    if (fishermen <= 6)
                    {
                        total = winter - (winter * 0.10);
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        total = winter - (winter * 0.15);
                    }
                    else if (fishermen >= 12)
                    {
                        total = winter - (winter * 0.25);
                    }
                    if (fishermen % 2 == 0)
                    {
                        total = total - (total * discount);
                    }
                    break;
            }
            if (budget >= total)
            {
                Console.WriteLine($"Yes! You have {(budget - total):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(total - budget):F2} leva.");
            }
        }
    }
}
