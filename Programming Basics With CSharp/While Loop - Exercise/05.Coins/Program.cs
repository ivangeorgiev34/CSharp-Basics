using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = 100 * double.Parse(Console.ReadLine());
            int counter = 0;

            // 2 , 1 , 0.50 , 0.20 , 0.10 , 0.05 , 0.02, 0.01

            while (change > 0)
            {
                if (change >= 200)
                {
                    change = change - 200;
                    counter++;
                }
                else if (change >= 100)
                {
                    change = change - 100;
                    counter++;
                }
                else if (change >= 50)
                {
                    change = change - 50;
                    counter++;
                }
                else if (change >= 20)
                {
                    change = change - 20;
                    counter++;
                }
                else if (change >= 10)
                {
                    change = change - 10;
                    counter++;
                }
                else if (change >= 5)
                {
                    change = change - 5;
                    counter++;
                }
                else if (change >= 2)
                {
                    change = change - 2;
                    counter++;
                }
                else if (change >= 1)
                {
                    change = change - 1;
                    counter++;
                }
                else
                {
                    change = 0;

                }
            }
            Console.WriteLine(counter);
        }
    }
}
