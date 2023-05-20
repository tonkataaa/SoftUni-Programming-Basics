using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int floor = floors; floor > 0; floor--)
            {

                for (int room = 0; room < rooms; room++)
                {
                    if (floor == floors)
                    {
                        Console.Write($"L{floor}{room} ");
                    }
                    else
                    {
                        if (floor % 2 == 0) // четен етаж
                        {
                            Console.Write($"O{floor}{room} ");
                        }
                        else // нечетен етаж
                        {
                            Console.Write($"A{floor}{room} ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
