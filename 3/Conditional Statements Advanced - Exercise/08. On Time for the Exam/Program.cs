using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int arrive = int.Parse(Console.ReadLine());
            int minArrive = int.Parse(Console.ReadLine());

            int examTime = timeExam * 60 + minExam;
            int arrivingTime = arrive * 60 + minArrive;

            int timeDifference = examTime - arrivingTime;

            if (timeDifference < 0)
            {
                Console.WriteLine("Late");
                int timeAbsolute = Math.Abs(timeDifference);

                if (timeAbsolute < 60)
                {
                    Console.WriteLine($"{timeAbsolute} minutes after the start");
                }
                else
                {
                    int hour = timeAbsolute / 60;
                    int minute = timeAbsolute % 60;
                    Console.WriteLine($"{hour}:{minute:D2} hours after the start");
                }
            }
            else if (timeDifference > 30)
            {
                Console.WriteLine("Early");
                if (timeDifference < 60)
                {
                    Console.WriteLine($"{timeDifference} minutes before the start");
                }
                else
                {
                    int hour = timeDifference / 60;
                    int minute = timeDifference % 60;
                    Console.WriteLine($"{hour}:{minute:D2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("On Time");
                if (timeDifference > 0)
                {
                    Console.WriteLine($"{timeDifference} minutes before the start");
                }
            }
        }
    }
}
