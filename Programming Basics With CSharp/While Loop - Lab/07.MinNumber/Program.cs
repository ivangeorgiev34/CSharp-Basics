using System;

namespace _07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int minNumber = int.MaxValue;
            while (command != "Stop")
            {
                int commandInt = int.Parse(command);
                if (commandInt < minNumber)
                {
                    minNumber = commandInt;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
