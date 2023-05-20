using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int h = 0; h <= 23; h++) //h=1
            {
                for (int m = 0; m <= 59; m++)
                {
                    Console.WriteLine($"{h}:{m}"); //0:00 ---> 0:01 ----> 0:02                   
                }
            }
        }
    }
}
