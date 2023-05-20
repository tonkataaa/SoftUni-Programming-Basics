using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int sum = 0;


            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num >= maxNum)
                {
                    maxNum = num;
                }
            }

            sum -= maxNum; // НЕ СЕ ПРАВИ В FOR-ЦИКЪЛА // Сумата на всички останали числа

            if (sum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNum - sum)}");
            }
        }
    }
}
