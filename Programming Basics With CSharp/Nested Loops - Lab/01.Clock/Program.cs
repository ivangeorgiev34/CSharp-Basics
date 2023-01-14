using System;

namespace _01.Clock
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 23; i++)
            {
                for (int p = 0; p <= 59; p++)
                {
                    Console.WriteLine($"{i}:{p}");
                }
            }
        }
    }
}
