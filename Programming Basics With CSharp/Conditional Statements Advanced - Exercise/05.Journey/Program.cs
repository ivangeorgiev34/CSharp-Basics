using System;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            double total = 0.0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        total = budget * 0.3;
                        break;
                    case "winter":
                        total = budget * 0.7;
                        break;
                }
            }
            else if (budget <= 1000)
            {


                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        total = budget * 0.4;
                        break;
                    case "winter":
                        total = budget * 0.8;
                        break;
                }

            }
            else
            {
                destination = "Europe";

                total = budget * 0.9;

            }

            Console.WriteLine($"Somewhere in {destination}");
            if (destination == "Europe")
            {
                Console.WriteLine($"Hotel - {total:F2}");
            }
            else if (season == "summer")
            {
                Console.WriteLine($"Camp - {total:F2}");
            }
            else if (season == "winter")
            {
                Console.WriteLine($"Hotel - {total:F2}");
            }
        }
    }
}
