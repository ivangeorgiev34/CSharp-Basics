using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPacketsOfDogs = int.Parse(Console.ReadLine());
            int numberOfPacketsOfCats = int.Parse(Console.ReadLine());
            double finalPriceDogs = numberOfPacketsOfDogs * 2.50;
            int finalPriceCats = numberOfPacketsOfCats * 4;
            double totalPrice = finalPriceDogs + finalPriceCats;

            Console.WriteLine($"{totalPrice} lv.");
        }
    }
}
