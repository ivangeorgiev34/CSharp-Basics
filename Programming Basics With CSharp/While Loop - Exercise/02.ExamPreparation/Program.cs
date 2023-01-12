using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int badGradesCounter = 0;
            int counterDoneExercises = 0;
            double gradeSum = 0;
            string lastExercises = string.Empty;

            while (input != "Enough")
            {
                lastExercises = input;
                int grade = int.Parse(Console.ReadLine());

                gradeSum = gradeSum + grade;
                counterDoneExercises++;

                if (grade <= 4)
                {
                    badGradesCounter++;
                    if (badGradesCounter == badGrades)
                    {
                        Console.WriteLine($"You need a break, {badGrades} poor grades.");
                        break;
                    }

                }
                input = Console.ReadLine();


            }
            if (badGradesCounter < badGrades)
            {
                Console.WriteLine($"Average score: {gradeSum / counterDoneExercises:f2}");
                Console.WriteLine($"Number of problems: {counterDoneExercises}");
                Console.WriteLine($"Last problem: {lastExercises}");
            }

        }
    }
}
