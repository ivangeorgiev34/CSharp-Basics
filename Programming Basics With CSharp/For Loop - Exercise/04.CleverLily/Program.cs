using System;

namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            double laundryMachinePrice = double.Parse(Console.ReadLine());
            int priceForOneToy = int.Parse(Console.ReadLine());

            double moneyTotal = 0;
            int moneyGatheredEvenYears = 0;
            int toysGathered = 0;

            for (int i = 1; i <= years; i++)
            {
                if (i % 2 == 0)
                {


                    moneyGatheredEvenYears = moneyGatheredEvenYears + (i * 5);
                }
                else
                {
                    toysGathered++;
                }
            }

            int moneyGatheredOddYears = toysGathered * priceForOneToy;
            moneyTotal = (moneyGatheredEvenYears + moneyGatheredOddYears) - years / 2;



            if (laundryMachinePrice <= moneyTotal)
            {
                Console.WriteLine($"Yes! {moneyTotal - laundryMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {laundryMachinePrice - moneyTotal:f2}");
            }
        }
    }
}
