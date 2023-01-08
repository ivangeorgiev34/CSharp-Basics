using System;

namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentsPlayed = int.Parse(Console.ReadLine());
            int pointFromBeggining = int.Parse(Console.ReadLine());

            double points = 0;
            double wonTournaments = 0;

            for (int i = 1; i <= tournamentsPlayed; i++)
            {
                string stage = Console.ReadLine();
                if (stage == "W")
                {
                    wonTournaments++;
                    pointFromBeggining += 2000;
                    points += 2000;
                }
                else if (stage == "F")
                {
                    pointFromBeggining += 1200;
                    points += 1200;
                }
                else if (stage == "SF")
                {
                    pointFromBeggining += 720;
                    points += 720;
                }

            }

            Console.WriteLine($"Final points: {pointFromBeggining}");
            Console.WriteLine($"Average points: {Math.Floor(points / tournamentsPlayed)}");
            Console.WriteLine($"{(wonTournaments / tournamentsPlayed) * 100:f2}%");
        }
    }
}
