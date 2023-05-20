using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Пиша от конзолата
            string project = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            //2. Намираме колко са свободните места в залата
            double income = row * columns;

            //3. Проверки за какъв е типа
            if (project == "Premiere") // 12лв
            {
                income *= 12; //кратък запис
                //дълъг: income = income*12;
            }
            else if (project == "Normal") // 7.50лв
            {
                income *= 7.50;
            }
            else if (project == "Discount") // 5.00лв
            {
                income *= 5;
            }

            //4. За отпечатване (Console.WriteLine("{0:f2} leva", income)
            Console.WriteLine("{0:F2} leva", income);

        }
    }
}
