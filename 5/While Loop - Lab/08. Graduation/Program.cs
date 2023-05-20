using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            tring name = Console.ReadLine();

            int grade = 1;
            int classRepetition = 0;
            double gradesSum = 0;
            while (grade <= 12)
            {
                double gradeMark = double.Parse(Console.ReadLine());
                if (gradeMark < 4)
                {
                    classRepetition++; // повтаря класа

                    if (classRepetition > 1)
                    {
                        break;
                    }
                    continue;
                }
                gradesSum += gradeMark;
                grade++;
            }

            if (classRepetition > 1)
            {
                //Изключен
                Console.WriteLine($"{name} has been excluded at {grade} grade");
            }
            else
            {
                //Завършва
                double averageGrade = gradesSum / (grade - 1);
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:F2}");
            }
        }
    }
}
