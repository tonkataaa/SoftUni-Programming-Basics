using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string form = Console.ReadLine();
            double area = 0;

            if (form == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (form == "rectangle")
            {
                double side = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                area = side * side2;
            }
            else if (form == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
            }
            else if (form == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = side * height / 2;
            }
            Console.WriteLine($"{area:f3}");
        }
    }
}
