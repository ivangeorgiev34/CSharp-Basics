using System;

namespace _03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            double p1numbersInRange = 0;
            double p2numbersInRange = 0;
            double p3numbersInRange = 0;
            double p4numbersInRange = 0;
            double p5numbersInRange = 0;


            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());



                if (num < 200)
                {
                    p1numbersInRange += 1;
                }
                else if (num >= 200 && num <= 399)
                {
                    p2numbersInRange += 1;
                }
                else if (num >= 400 && num <= 599)
                {
                    p3numbersInRange += 1;
                }
                else if (num >= 600 && num <= 799)
                {
                    p4numbersInRange += 1;
                }
                else if (num >= 800)
                {
                    p5numbersInRange += 1;
                }




            }
            Console.WriteLine($"{p1numbersInRange / n * 100:f2}%");
            Console.WriteLine($"{(p2numbersInRange / n) * 100:f2}%");
            Console.WriteLine($"{(p3numbersInRange / n) * 100:f2}%");
            Console.WriteLine($"{(p4numbersInRange / n) * 100:f2}%");
            Console.WriteLine($"{(p5numbersInRange / n) * 100:f2}%");
        }
    }
}
