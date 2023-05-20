using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Numbers_N._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
