using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            string input;
            while (steps < 10000)
            {
                input = Console.ReadLine();
                if (input == "Going home")
                {
                    steps += int.Parse(Console.ReadLine());
                    break;
                }
                steps += int.Parse(input);
            }
            if (steps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{steps - 10000} steps over the goal!");
            }
            else
                Console.WriteLine($"{Math.Abs(10000 - steps)} more steps to reach goal.");
        }
    }
}
