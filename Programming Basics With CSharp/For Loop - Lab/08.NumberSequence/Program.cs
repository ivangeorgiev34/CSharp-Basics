using System;

namespace _08.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int MaxNumber = int.MinValue;
            int MinNumber = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > MaxNumber)
                {
                    MaxNumber = number;
                }
                if (number < MinNumber)
                {
                    MinNumber = number;
                }
            }
            Console.WriteLine($"Max number: {MaxNumber}");
            Console.WriteLine($"Min number: {MinNumber}");
        }
    }
}
