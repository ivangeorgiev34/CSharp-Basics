using System;

namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());


            double volumeOfAquarium = lenght * width * height;
            double volumeInLiters = volumeOfAquarium / 1000;
            double occupancyRate = percentage / 100;
            double litersNeeded = volumeInLiters * (1 - occupancyRate);


            Console.WriteLine(litersNeeded);
        }
    }
}
