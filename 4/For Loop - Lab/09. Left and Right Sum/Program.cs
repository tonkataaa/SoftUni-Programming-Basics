using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sum1 = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum1 = sum1 + number;
            }

            double sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum2 = sum2 + number;
            }

            double diff = sum1 - sum2;
            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(diff)}");
            }
        }
    }
}
