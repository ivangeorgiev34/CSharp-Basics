using System;

namespace _08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameStudent = Console.ReadLine();
            int counter = 0;
            int expeledCounter = 0;
            double gradeSum = 0;

            while (counter < 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4)
                {
                    expeledCounter++;
                    if (expeledCounter == 2)
                    {
                        Console.WriteLine($"{nameStudent} has been excluded at {counter} grade");
                        return;
                    }
                }

                counter++;
                gradeSum += grade;

                if (counter == 12)
                {
                    Console.WriteLine($"{nameStudent} graduated. Average grade: {gradeSum / 12:f2}");

                }
            }
        }
    }
}
