using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Извеждам си данни от вход
            double kmForGreening = double.Parse(Console.ReadLine()) * 7.61; // 7.61лв на квадрат
            double discount = kmForGreening * 0.18; //18% от цената за целия двор

            //2. Калкулира се крайната цена
            double totalSum = kmForGreening - discount;

            //3. Изписвам в конзолата
            Console.WriteLine($"The final price is: {totalSum} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
