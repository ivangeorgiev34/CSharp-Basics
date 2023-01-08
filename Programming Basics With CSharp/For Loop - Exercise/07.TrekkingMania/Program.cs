using System;

namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupNumber = int.Parse(Console.ReadLine());

            double musala = 0;
            double monblan = 0;
            double kilimandjaro = 0;
            double k2 = 0;
            double everest = 0;
            double sum = 0;
            
            for (int i = 1; i <= groupNumber; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());
                if (peopleInGroup <= 5)
                {
                    musala += peopleInGroup;
                }
                else if (peopleInGroup >= 6 && peopleInGroup <= 12)
                {
                    monblan += peopleInGroup;
                }
                else if (peopleInGroup >= 13 && peopleInGroup <= 25)
                {
                    kilimandjaro += peopleInGroup;
                }
                else if (peopleInGroup >= 26 && peopleInGroup <= 40)
                {
                    k2 += peopleInGroup;
                }
                else
                {
                    everest += peopleInGroup;
                }
                sum += peopleInGroup;
            }

            Console.WriteLine($"{(musala / sum) * 100:f2}%");
            Console.WriteLine($"{(monblan / sum) * 100:f2}%");
            Console.WriteLine($"{(kilimandjaro / sum) * 100:f2}%");
            Console.WriteLine($"{(k2 / sum) * 100:f2}%");
            Console.WriteLine($"{(everest / sum) * 100:f2}%");
        }
    }
}
