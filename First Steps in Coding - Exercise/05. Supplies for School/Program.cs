using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Изписвам данните от вход
            //Пакет химикали (един струва 5.80лв.)
            double pencilsQuantity = double.Parse(Console.ReadLine()) * 5.80;
            //Пакет маркери (един струва 7.20лв.)
            double markerQuantity = double.Parse(Console.ReadLine()) * 7.20;
            //Литри препарат (1.20лв за литър)
            double liters = double.Parse(Console.ReadLine()) * 1.20;
            // Процент намаление
            double discount = double.Parse(Console.ReadLine());

            //Цена на всички материали
            double obshtoCenaZaMateriali = pencilsQuantity + markerQuantity + liters;

            //Цена с намаление
            double discountedPrice = obshtoCenaZaMateriali - (obshtoCenaZaMateriali * (discount / 100));

            Console.WriteLine(discountedPrice);
        }
    }
}
