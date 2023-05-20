using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numbersSum = 0;
            while (numbersSum < n)
            {
                int number = int.Parse(Console.ReadLine());
                numbersSum += number;
            }
            Console.WriteLine(numbersSum);
        }
    }
}
