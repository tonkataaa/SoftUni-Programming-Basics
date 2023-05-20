using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double dogFood = double.Parse(Console.ReadLine()) * 2.50;
            double catFood = double.Parse(Console.ReadLine()) * 4;
            double totalSum = dogFood + catFood;
            
            Console.WriteLine($"{totalSum} lv.");         
        }
    }
}
