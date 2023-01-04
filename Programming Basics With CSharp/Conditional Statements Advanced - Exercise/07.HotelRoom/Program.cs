using System;

namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int sleepovers = int.Parse(Console.ReadLine());
            double totalStudio = 0.0;
            double totalApartment = 0.0;
            switch (month)
            {
                case "May":
                case "October":
                    if (sleepovers > 7 && sleepovers < 14)
                    {
                        totalStudio = (50 - (0.05 * 50)) * sleepovers;
                        totalApartment = 65 * sleepovers;
                    }
                    else if (sleepovers > 14)
                    {
                        totalStudio = ((50 - (0.3 * 50))) * sleepovers;
                        totalApartment = (65 - (0.1 * 65)) * sleepovers;
                    }
                    else
                    {
                        totalStudio = 50 * sleepovers;
                        totalApartment = 65 * sleepovers;
                    }
                    break;
                case "June":
                case "September":
                    if (sleepovers > 14)
                    {
                        totalStudio = ((75.20 - (0.2 * 75.20))) * sleepovers;
                        totalApartment = (68.70 - (0.1 * 68.70)) * sleepovers;
                    }
                    else
                    {
                        totalStudio = 75.20 * sleepovers;
                        totalApartment = 68.70 * sleepovers;
                    }
                    break;
                case "July":
                case "August":
                    if (sleepovers > 14)
                    {
                        totalStudio = 76 * sleepovers;
                        totalApartment = (77 - (0.1 * 77)) * sleepovers;
                    }
                    else
                    {
                        totalStudio = 76 * sleepovers;
                        totalApartment = 77 * sleepovers;
                    }
                    break;


            }
            Console.WriteLine($"Apartment: {totalApartment:F2} lv.");
            Console.WriteLine($"Studio: {totalStudio:F2} lv.");
        }
    }
}
