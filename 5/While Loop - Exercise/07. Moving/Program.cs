using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int depth = int.Parse(Console.ReadLine());
            int cubicMeters = width * height * depth;
            string input;
            while (cubicMeters > 0)
            {
                input = Console.ReadLine();

                if (input == "Done")
                {

                    break;
                }
                cubicMeters -= int.Parse(input);
            }
            if (cubicMeters > 0)
            {
                Console.WriteLine($"{cubicMeters} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(cubicMeters)} Cubic meters more.");

            }
        }
    }
}
