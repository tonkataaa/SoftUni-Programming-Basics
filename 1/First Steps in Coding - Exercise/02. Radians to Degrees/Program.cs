using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Четем радиани от конзолата
            double radians = double.Parse(Console.ReadLine());
            //2. Преобразуваме от радиани в градуси (градус = радиан * 180 / π.)
            double degrees = radians * 180 / Math.PI;
            //3. Отпечатваме градусите на конзолата
            Console.WriteLine(degrees);
        }
    }
}
