using System;

namespace _10.InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool check = (num >= 100 && num <= 200) || num == 0;
            if (!check)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
