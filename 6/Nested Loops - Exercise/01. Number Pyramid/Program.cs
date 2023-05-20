using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int current = 1;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{current} ");
                    current++;

                    if (current > n)
                    {
                        break;
                    }
                }

                Console.WriteLine();
                if (current > n)
                {
                    break;
                }
            }
        }
    }
}
