using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string fee = Console.ReadLine();
            double total = 0;

            while (fee != "NoMoreMoney")
            {
                double ammount = double.Parse(fee);

                if (ammount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                total += ammount;
                Console.WriteLine($"Increase: {ammount:f2}");
                fee = Console.ReadLine();
            }
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
