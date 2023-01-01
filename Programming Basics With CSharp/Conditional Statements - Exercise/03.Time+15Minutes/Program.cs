using System;

namespace _03.Time_15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int minutesSum = minutes + 15;



            if (hour != 23 && minutesSum >= 60 && (minutesSum % 60) < 10)
            {

                Console.WriteLine($"{hour + 1}:0{minutesSum % 60}");

            }
            else if (hour != 23 && minutesSum >= 60)
            {
                Console.WriteLine($"{hour + 1}:{minutesSum % 60}");
            }
            else if (hour != 23 && minutesSum < 60)
            {
                Console.WriteLine($"{hour}:{minutesSum}");

            }
            else if (minutesSum < 60)
            {
                Console.WriteLine($"{hour}:{minutesSum}");
            }
            else if (minutesSum >= 60 && (minutesSum % 60) < 10)
            {
                Console.WriteLine($"0:0{minutesSum % 60}");
            }
            else
            {
                Console.WriteLine($"0:{minutesSum % 60}");
            }
        }
    }
}
