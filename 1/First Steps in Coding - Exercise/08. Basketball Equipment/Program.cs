using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Цена на тренировката за година (чете се един ред)
            double cenaNaGodina = double.Parse(Console.ReadLine());

            //2. Цена на баскетболните кецове (40% по-евтина от таксата)
            double shoesPrice = cenaNaGodina - cenaNaGodina * 0.4;

            //3. Цена на екип (20% по-евтин от кецовете)
            double clothesPrice = shoesPrice - shoesPrice * 0.2;

            //4. Цена за топка ( 1/4 от екип)
            double ballPrice = clothesPrice / 4;

            //5. Цена за аксесоари - 1/5 от топка
            double accesoriesPrice = ballPrice / 5;

            //6. Общата сума
            double totalPrice = cenaNaGodina + shoesPrice + clothesPrice + ballPrice + accesoriesPrice;

            //7. Изписвам в конзолата
            Console.WriteLine(totalPrice);
        }
    }
}
