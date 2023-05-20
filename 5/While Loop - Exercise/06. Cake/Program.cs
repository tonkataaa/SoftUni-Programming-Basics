using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int Height = int.Parse(Console.ReadLine());
            int cakesSize = Height * width;
            int cakepieces = cakesSize;
            string input = string.Empty;
            while (input != "STOP")
            {
                input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }
                else
                {
                    int piece = int.Parse(input);
                    cakepieces -= piece;
                    if (cakepieces < 0)
                    {
                        Console.WriteLine($"No more cake left! You need {Math.Abs(cakepieces)} pieces more.");
                        break;
                    }
                }
            }
            if (cakepieces > 0)
            {
                Console.WriteLine($"{cakepieces} pieces are left.");

            }

        }
    }
}
