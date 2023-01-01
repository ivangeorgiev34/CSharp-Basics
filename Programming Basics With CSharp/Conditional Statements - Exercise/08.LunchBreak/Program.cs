    using System;

    namespace _08.LunchBreak
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                string name = Console.ReadLine();
                double episodeTime = int.Parse(Console.ReadLine());
                double restTime = int.Parse(Console.ReadLine());

                double lunch = (restTime / 8);
                double rest = restTime / 4;
                double leftTime = restTime - lunch - rest;
                if (leftTime >= episodeTime)
                {
                    Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(leftTime- episodeTime)} minutes free time.");
                }
                else
                {
                    Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(episodeTime - leftTime)} more minutes.");
                }
            }
        }
    }
