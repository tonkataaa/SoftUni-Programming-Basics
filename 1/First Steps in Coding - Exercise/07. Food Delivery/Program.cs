using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Чета от конзолата данни и ги записвам в променливи (вход)
            // Пилешко меню (цена 10.35лв за едно)
            double chickenMenu = double.Parse(Console.ReadLine()) * 10.35;
            //Меню с риба (12.40лв за едно)
            double fishMenu = double.Parse(Console.ReadLine()) * 12.40;
            //Вегетарианско меню (8.15лв за едно)
            double vegeterianMenu = double.Parse(Console.ReadLine()) * 8.15;

            //2. Обща цена за менютата
            double totalSum = chickenMenu + fishMenu + vegeterianMenu;

            //3. Цена на десерта
            double dessertPrice = 0.20 * totalSum;

            //4. Цена на доставка
            double shippingPrice = 2.50;

            //5. Обща цена на поръчката
            double orderPrice = totalSum + dessertPrice + shippingPrice;

            //6. Изписвам в конзолата
            Console.WriteLine($"{orderPrice}");

        }
    }
}
