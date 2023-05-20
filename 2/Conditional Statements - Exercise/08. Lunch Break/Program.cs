using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Изписвам от вход
            string series = Console.ReadLine();
            double episodTime = double.Parse(Console.ReadLine());
            double @break = double.Parse(Console.ReadLine());

            //2.Пресмятаме времената
            // време за обяд
            double lunch = @break * 1 / 8;

            //време за отдих
            double chilling = @break * 1 / 4;

            //останало време
            double timeLeft = @break - lunch - chilling;

            //3. Да сравним останалото време с трайноста на епизода
            if (timeLeft >= episodTime)
            {
                Console.WriteLine($" You have enough time to watch {series} and left with {Math.Ceiling(timeLeft - episodTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {series}, you need {Math.Ceiling(episodTime - timeLeft)} more minutes.");
            }

        }
    }
}
