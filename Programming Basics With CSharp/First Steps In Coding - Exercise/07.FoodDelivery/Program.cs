using System;

namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfMenuChicken = int.Parse(Console.ReadLine());
            int numOfMenuFish = int.Parse(Console.ReadLine());
            int numOfMenuVegan = int.Parse(Console.ReadLine());

            double priceChickenMenu = numOfMenuChicken * 10.35;
            double priceFishMenu = numOfMenuFish * 12.4;
            double priceVeganMenu = numOfMenuVegan * 8.15;
            double sumOfMenus = priceChickenMenu + priceFishMenu + priceVeganMenu;
            double dessert = sumOfMenus * 0.20;
            double totalSum = 2.50 + sumOfMenus + dessert;

            Console.WriteLine(totalSum);

        }
    }
}
