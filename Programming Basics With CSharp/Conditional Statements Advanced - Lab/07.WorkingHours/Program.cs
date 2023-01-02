using System;

namespace _07.WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            switch (day)
            {
                case "Monday":
                    switch (hour)
                    {
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                            Console.WriteLine("open");
                            break;
                        default:
                            Console.WriteLine("closed");
                            break;
                    }
                    break;
                case "Tuesday":
                    switch (hour)
                    {
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                            Console.WriteLine("open");
                            break;
                        default:
                            Console.WriteLine("closed");
                            break;
                    }
                    break;
                case "Wednesday":
                    switch (hour)
                    {
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                            Console.WriteLine("open");
                            break;
                        default:
                            Console.WriteLine("closed");
                            break;

                    }
                    break;
                case "Thursday":
                    switch (hour)
                    {
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                            Console.WriteLine("open");
                            break;
                        default:
                            Console.WriteLine("closed");
                            break;
                    }
                    break;
                case "Friday":
                    switch (hour)
                    {
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                            Console.WriteLine("open");
                            break;
                        default:
                            Console.WriteLine("closed");
                            break;
                    }
                    break;
                case "Saturday":
                    switch (hour)
                    {
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                            Console.WriteLine("open");
                            break;
                        default:
                            Console.WriteLine("closed");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("closed");
                    break;



            }
        }
    }
}
