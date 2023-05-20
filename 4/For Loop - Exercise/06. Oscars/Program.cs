using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Чета от вход
            string name = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int judgesNum = int.Parse(Console.ReadLine());

            double sumPoints = points;

            for (int i = 0; i < judgesNum; i++)
            {
                string judge = Console.ReadLine();
                double Jurypoints = double.Parse(Console.ReadLine());
                double pointsNow = (judge.Length * Jurypoints) / 2;
                sumPoints = sumPoints + pointsNow;

                if (sumPoints >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {sumPoints:F1}!");
                    break;
                }
            }


            if (sumPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {name} you need {1250.5 - sumPoints:F1} more!");
            }


        }
    }
}
