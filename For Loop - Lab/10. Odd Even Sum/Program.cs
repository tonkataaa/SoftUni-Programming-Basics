using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumeven = 0;
            double sumodd = 0;

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumeven += numbers;
                }
                else if (i % 2 != 0)
                {
                    sumodd += numbers;
                }
            }

            if (sumeven == sumodd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumeven}");

            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumeven - sumodd)}");
            }
        }
    }
}
