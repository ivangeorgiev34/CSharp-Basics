using System;

namespace _06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            double result = 0.0;
            switch (symbol)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{firstNumber} {symbol} {secondNumber} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} {symbol} {secondNumber} = {result} - odd");
                    }
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{firstNumber} {symbol} {secondNumber} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} {symbol} {secondNumber} = {result} - odd");
                    }
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{firstNumber} {symbol} {secondNumber} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} {symbol} {secondNumber} = {result} - odd");
                    }
                    break;
                case '/':
                    if (secondNumber == 0)
                    {
                        Console.WriteLine($"Cannot divide {firstNumber} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} {symbol} {secondNumber} = {(firstNumber / secondNumber):F2}");
                    }
                    break;
                case '%':
                    result = firstNumber % secondNumber;
                    if (secondNumber == 0)
                    {
                        Console.WriteLine($"Cannot divide {firstNumber} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} {symbol} {secondNumber} = {firstNumber % secondNumber}");
                    }
                    break;
            }
        }
    }
}
