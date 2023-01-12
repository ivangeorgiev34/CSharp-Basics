using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int steps = 0;

            while (input != "Going home")
            {
                steps += int.Parse(input);


                if (steps >= 10000)
                {
                    break;

                }
                input = Console.ReadLine();
            }
            if (input == "Going home")
            {
                input = Console.ReadLine();
                steps += int.Parse(input);
            }

            if (steps < 10000)
            {
                Console.WriteLine($"{10000 - steps} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{steps - 10000} steps over the goal!");
            }
        }
    }
}
