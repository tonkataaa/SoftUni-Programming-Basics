using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
             //1. Записвам данните от вход
            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            //2. Почвам да пресмятам
            // сума
            double sum = (puzzels * 2.60) + (dolls * 3) + (bears * 4.10) + (minions * 8.20) + (trucks * 2);

            //брой на играчките
            int toysQuantity = puzzels + dolls + bears + minions + trucks;

            //отстъпка
            double otstupka = sum * 0.25;

            // ако играчките са 50 или повече
            if (toysQuantity >= 50)
            {

                sum = sum - otstupka;
               
            }
            else
            {
                sum = sum * 1;
            }

            double earning = sum - (sum * 0.1);

            if (earning >= holidayPrice)
            {
                Console.WriteLine($"Yes! {earning - holidayPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {holidayPrice - earning:F2} lv needed.");
            }
        }
    }
}
