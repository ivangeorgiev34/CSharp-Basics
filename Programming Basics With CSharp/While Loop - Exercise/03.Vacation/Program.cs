using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyOwned = double.Parse(Console.ReadLine());

            int spendCounter = 0;
            int days = 0;

            while (moneyOwned < moneyNeeded && spendCounter < 5)
            {
                string operation = Console.ReadLine();
                double ammount = double.Parse(Console.ReadLine());

                if (operation == "spend")
                {
                    moneyOwned = moneyOwned - ammount;
                    spendCounter++;
                    days++;

                    if (moneyOwned < 0)
                    {
                        moneyOwned = 0;
                    }
                }
                if (operation == "save")
                {
                    moneyOwned = moneyOwned + ammount;
                    days++;
                    spendCounter = 0;
                    if (moneyOwned >= moneyNeeded)
                    {
                        Console.WriteLine($"You saved the money for {days} days.");
                        break;
                    }
                }
                if (spendCounter == 5)
                {
                    Console.WriteLine($"You can't save the money.");
                    Console.WriteLine(days);
                }

            }
        }
    }
}
