using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int first = 1; first <= 10; first++)
            {
                for (int second = 1; second <= 10; second++)
                {
                    int result = first * second;
                    Console.WriteLine($"{first} * {second} = {result}");
                }
            }
        }
    }
}
