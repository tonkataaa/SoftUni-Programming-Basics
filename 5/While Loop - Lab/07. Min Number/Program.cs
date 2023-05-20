using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double minNum = double.MaxValue;

            while ((input = Console.ReadLine()) != "Stop")
            {
                int n = int.Parse(input);

                if (minNum > n)
                {
                    minNum = n;
                }
            }
            Console.WriteLine(minNum);
        }
    }
}
