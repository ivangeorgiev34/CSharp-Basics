using System;

namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double total = 0.0;

            switch (flowersType)
            {
                case "Roses":
                    if (flowersCount > 80)
                    {
                        total = flowersCount * 5 * 0.9;
                    }
                    else
                    {
                        total = flowersCount * 5;
                    }
                    break;
                case "Dahlias":
                    if (flowersCount > 90)
                    {
                        total = flowersCount * 3.8 * 0.85;
                    }
                    else
                    {
                        total = flowersCount * 3.8;
                    }
                    break;
                case "Tulips":
                    if (flowersCount > 80)
                    {
                        total = flowersCount * 2.8 * 0.85;
                    }
                    else
                    {
                        total = flowersCount * 2.8;
                    }
                    break;
                case "Narcissus":
                    if (flowersCount < 120)
                    {
                        total = flowersCount * 3 * 1.15;
                    }
                    else
                    {
                        total = flowersCount * 3;
                    }
                    break;
                case "Gladiolus":
                    if (flowersCount < 80)
                    {
                        total = flowersCount * 2.5 * 1.20;
                    }
                    else
                    {
                        total = flowersCount * 2.5;
                    }
                    break;

            }
            if (budget >= total)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {(budget - total):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(total - budget):F2} leva more.");
            }
        }
    }
}
