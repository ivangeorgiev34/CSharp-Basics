using System;

namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taxForBasketball = int.Parse(Console.ReadLine());


            double shoes = taxForBasketball - (taxForBasketball * 0.40);
            double kit = shoes - (shoes * 0.20);
            double ball = kit * 0.25;
            double accessories = ball * 0.20;

            Console.WriteLine(shoes + kit + ball + accessories + taxForBasketball);
        }
    }
}
