using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int numPieces = width * lenght;
            string command = string.Empty;
            int pieces = 0;

            while (command != "STOP")
            {
                command = Console.ReadLine();


                if (command == "STOP")
                {
                    Console.WriteLine($"{numPieces} pieces are left.");
                    break;
                }
                numPieces = numPieces - int.Parse(command);
                pieces = pieces + int.Parse(command);
                if (numPieces < 0)
                {
                    Console.WriteLine($"No more cake left! You need {pieces - (width * lenght)} pieces more.");
                    break;
                }
            }
        }
    }
}
