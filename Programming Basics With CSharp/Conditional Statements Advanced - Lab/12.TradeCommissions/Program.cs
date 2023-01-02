using System;

namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bourgas
            //1500

            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0.0;
            if (0 <= sales && sales <= 500)
            {
                switch (town)
                {
                    case "Sofia":
                        commission = 0.05;
                        commission = sales * commission;
                        Console.WriteLine($"{commission:F2}");
                        break;
                    case "Varna":
                        commission = 0.045;
                        commission = sales * commission;
                        Console.WriteLine($"{commission:F2}");
                        break;
                    case "Plovdiv":
                        commission = 0.055;
                        commission = sales * commission;
                        Console.WriteLine($"{commission:F2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

            }
            else if (500 < sales && sales <= 1000)
            {
                switch (town)
                {
                    case "Sofia":
                        commission = 0.07;
                        commission = sales * commission;
                        Console.WriteLine($"{commission:F2}");
                        break;
                    case "Varna":
                        commission = 0.075;
                        commission = sales * commission;
                        Console.WriteLine($"{commission:F2}");
                        break;
                    case "Plovdiv":
                        commission = 0.08;
                        commission = sales * commission;
                        Console.WriteLine($"{commission:F2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

            }
            else if (1000 < sales && sales <= 10000)
            {
                switch (town)
                {
                    case "Sofia":
                        commission = 0.08;
                        commission = sales * commission;
                        Console.WriteLine($"{commission:F2}");
                        break;
                    case "Varna":
                        commission = 0.1;
                        commission = sales * commission;
                        Console.WriteLine($"{commission:F2}");
                        break;
                    case "Plovdiv":
                        commission = 0.12;
                        commission = sales * commission;
                        Console.WriteLine($"{commission:F2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

            }
            else if (sales > 10000)
            {
                switch (town)
                {
                    case "Sofia":
                        commission = 0.12;
                        commission = sales * commission;
                        Console.WriteLine($"{commission:F2}");
                        break;
                    case "Varna":
                        commission = 0.13;
                        commission = sales * commission;
                        Console.WriteLine($"{commission:F2}");
                        break;
                    case "Plovdiv":
                        commission = 0.145;
                        commission = sales * commission;
                        Console.WriteLine($"{commission:F2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
