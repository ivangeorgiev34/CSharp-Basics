using System;

namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPens = int.Parse(Console.ReadLine());
            int numberOfMarkers = int.Parse(Console.ReadLine());
            int litersOfDetergent = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine()) / 100;

            double pensPrice = numberOfPens * 5.8;
            double markersPrice = numberOfMarkers * 7.2;
            double detergentsPrice = litersOfDetergent * 1.2;
            double discount = (pensPrice + markersPrice + detergentsPrice) * percentage;
            double total = (pensPrice + markersPrice + detergentsPrice) - discount;

            Console.WriteLine(total);
        }
    }
}
