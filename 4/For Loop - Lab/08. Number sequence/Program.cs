using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxnumber = int.MinValue;
            int minnumber = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > maxnumber)
                {
                    maxnumber = number;
                }

                if (minnumber > number)
                {
                    minnumber = number;
                }
            }
            Console.WriteLine($"Max number: {maxnumber}");
            Console.WriteLine($"Min number: {minnumber}");
        }
    }
}
