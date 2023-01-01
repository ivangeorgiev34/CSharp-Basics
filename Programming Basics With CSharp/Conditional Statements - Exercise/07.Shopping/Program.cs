using System;

namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int rams = int.Parse(Console.ReadLine());

            double videocardSum = 250 * videocards;
            double processorSum = (videocardSum * 0.35) * processors;
            double ramSum = (videocardSum * 0.10) * rams;
            double productsSum = videocardSum + processorSum + ramSum;
            if (videocards > processors)
            {
                productsSum = productsSum - (productsSum * 0.15);
            }

            if (budget >= productsSum)
            {
                Console.WriteLine($"You have {(budget - productsSum):F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(productsSum - budget):F2} leva more!");
            }
        }
    }
}
