using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (time >= 10 && time <= 18 && day != "Sunday")
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
