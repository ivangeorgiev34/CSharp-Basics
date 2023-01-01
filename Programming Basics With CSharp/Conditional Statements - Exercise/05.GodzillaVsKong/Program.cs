using System;

namespace _05.GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budgetFilm = double.Parse(Console.ReadLine());
            int numStatists = int.Parse(Console.ReadLine());
            double costume = double.Parse(Console.ReadLine());
            double decorTotal = (budgetFilm * 0.10);
            double costumeStatist = costume * numStatists;
            if (numStatists > 150)
            {
                costumeStatist -= costumeStatist * 0.10;
            }
            if (decorTotal + costumeStatist > budgetFilm)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {((decorTotal + costumeStatist) - budgetFilm):F2} leva more.");
            }
            else
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {(budgetFilm - (decorTotal + costumeStatist)):F2} leva left.");
            }
        }
    }
}
