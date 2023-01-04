using System;

namespace _08.OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examHourIntoMinutes = 60 * examHour;
            int arrivalHourIntoMinutes = 60 * arrivalHour;
            string state = "";
            int minutes = 0;
            int hours = 0;

            if ((examHourIntoMinutes + examMinutes) >= (arrivalHourIntoMinutes + arrivalMinutes))
            {
                if (((examHourIntoMinutes + examMinutes) - (arrivalHourIntoMinutes + arrivalMinutes)) >= 60)
                {
                    state = "Early";
                    hours = ((examHourIntoMinutes + examMinutes) - (arrivalHourIntoMinutes + arrivalMinutes)) / 60;
                    minutes = ((examHourIntoMinutes + examMinutes) - (arrivalHourIntoMinutes + arrivalMinutes)) % 60;
                    Console.WriteLine(state);
                    if (minutes == 0)
                    {
                        Console.WriteLine($"{hours}:00 hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes} hours before the start");
                    }
                }
                else if ((examHourIntoMinutes + examMinutes) - (arrivalHourIntoMinutes + arrivalMinutes) > 30)
                {
                    state = "Early";
                    minutes = (examHourIntoMinutes + examMinutes) - (arrivalHourIntoMinutes + arrivalMinutes);
                    Console.WriteLine(state);
                    Console.WriteLine($"{minutes} minutes before the start");
                }
                else
                {
                    if (((examHourIntoMinutes + examMinutes) - (arrivalHourIntoMinutes + arrivalMinutes)) == 0)
                    {
                        state = "On time";
                        Console.WriteLine(state);
                    }
                    else
                    {
                        state = "On time";
                        minutes = (examHourIntoMinutes + examMinutes) - (arrivalHourIntoMinutes + arrivalMinutes);
                        Console.WriteLine(state);
                        Console.WriteLine($"{minutes} minutes before the start");
                    }
                }
            }
            else if ((examHourIntoMinutes + examMinutes) < (arrivalHourIntoMinutes + arrivalMinutes))
            {
                if ((arrivalHourIntoMinutes + arrivalMinutes) - (examHourIntoMinutes + examMinutes) >= 60)
                {
                    state = "Late";
                    hours = ((arrivalHourIntoMinutes + arrivalMinutes) - (examHourIntoMinutes + examMinutes)) / 60;
                    minutes = ((arrivalHourIntoMinutes + arrivalMinutes) - (examHourIntoMinutes + examMinutes)) % 60;
                    Console.WriteLine(state);
                    if (minutes == 0)
                    {
                        Console.WriteLine($"{hours}:00 hours after the start");

                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes} hours after the start");
                    }
                }
                else
                {
                    state = "Late";
                    minutes = (arrivalHourIntoMinutes + arrivalMinutes) - (examHourIntoMinutes + examMinutes);
                    Console.WriteLine(state);
                    Console.WriteLine($"{minutes} minutes after the start");
                }
            }
        }
    }
}
