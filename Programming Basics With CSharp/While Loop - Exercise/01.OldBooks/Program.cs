using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            int counter = 0;
            string book = Console.ReadLine(); 

            while (book != "No More Books")
            {

                if (searchedBook == book)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }
                counter++;
                book = Console.ReadLine();
                if (book == "No More Books")
                {
                    Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");
                    break;
                }
            }
        }
    }
}
