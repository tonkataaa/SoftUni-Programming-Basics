using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Numbers_1.N_with_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
