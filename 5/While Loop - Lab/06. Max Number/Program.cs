using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int maxNum = int.MinValue;

            while ((input = Console.ReadLine()) != "Stop")
            {
                int number = int.Parse(input);

                if (number > maxNum) // Ако сегашното число е по-голямо от максимума
                {
                    maxNum = number; //Сегашното е новия максимум
                }
            }
            Console.WriteLine(maxNum);
        }
    }
}
