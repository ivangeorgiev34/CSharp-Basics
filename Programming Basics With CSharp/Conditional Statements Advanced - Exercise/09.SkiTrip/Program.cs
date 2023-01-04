using System;

namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();
            const double roomForOnePerson = 18;
            const double apartment = 25;
            const double presidentApartment = 35;
            double total = 0.0;
            switch (room)
            {
                case "room for one person":
                    total = (days - 1) * (roomForOnePerson);
                    break;
                case "apartment":
                    if (days < 10)
                    {
                        total = ((days - 1) * (apartment)) * 0.7;

                    }
                    else if (days > 10 && days < 15)
                    {
                        total = ((days - 1) * (apartment)) * 0.65;
                    }
                    else
                    {
                        total = ((days - 1) * (apartment)) * 0.5;
                    }
                    break;
                case "president apartment":
                    if (days < 10)
                    {
                        total = ((days - 1) * (presidentApartment)) * 0.9;
                    }
                    else if (days > 10 && days < 15)
                    {
                        total = ((days - 1) * (presidentApartment)) * 0.85;
                    }
                    else
                    {
                        total = ((days - 1) * (presidentApartment)) * 0.8;
                    }
                    break;
            }
            if (rating == "positive")
            {
                total = total + (total * 0.25);
            }
            else
            {
                total = total - (total * 0.1);
            }
            Console.WriteLine($"{total:F2}");
        }
    }
}
