using System;

namespace _02.MultiplicationTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int p = 1; p <= 10; p++)
                {
                    Console.WriteLine($"{i} * {p} = {i * p}");
                }
            }
        }
    }
}
