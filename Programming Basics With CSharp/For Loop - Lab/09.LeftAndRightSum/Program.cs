using System;

namespace _09.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                 sum1 = sum1 + num;
            }

            for (int j = 0; j < n; j++)
            {
                int num = int.Parse(Console.ReadLine());
                 sum2 = sum2 + num;
            }

            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
                
            }
            else if (sum1 != sum2)
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum1 - sum2)}");
                
            }
        }
    }
}
