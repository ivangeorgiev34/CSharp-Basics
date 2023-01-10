using System;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxNumber = int.MinValue;
            while (input != "Stop")
            {

                int inputInInt = int.Parse(input);
                if (inputInInt > maxNumber)
                {
                    maxNumber = inputInInt;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}
