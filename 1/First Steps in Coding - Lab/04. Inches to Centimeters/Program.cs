using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {          
            double cm = double.Parse(Console.ReadLine());           
            double converter = cm * 2.54;

            Console.WriteLine(converter);
        }
    }
}
