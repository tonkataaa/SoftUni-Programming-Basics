using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0) // модулно деление да се дели на 2 и да се получава 0, за да е четно
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
