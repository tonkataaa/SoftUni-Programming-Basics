using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Прочитаме от конзолата
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeInSecFor1m = double.Parse(Console.ReadLine());



            //2. Намираме колко пъти Иван ще се забави
            double delay = Math.Floor(distance / 15) * 12.5;

            //3. Какво е времето на Иван
            // разстоянието*времето за 1м + забавянатео
            double totalTime = distance * timeInSecFor1m + delay;

            //4. Успял ли е да подобри рекорда
            if (totalTime < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(recordInSeconds - totalTime):F2} seconds slower.");
            }
        }
    }
}
