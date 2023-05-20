using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournirs = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());
            int points2 = 0;
            int wonTournaments = 0;
            points2 = points;


            for (int i = 0; i < tournirs; i++)
            {
                string results = Console.ReadLine();

                if (results == "W")
                {
                    points2 += 2000;
                    wonTournaments++;
                }
                else if (results == "F")
                {
                    points2 += 1200;
                }
                else if (results == "SF")
                {
                    points2 += 720;
                }

            }
            double average = (points2 - points) / tournirs;
            double percent = ((double)wonTournaments / tournirs) * 100;

            Console.WriteLine($"Final points: {points2}");
            Console.WriteLine($"Average points: {Math.Floor(average)}");
            Console.WriteLine($"{percent:F2}%");


        }
    }
}
