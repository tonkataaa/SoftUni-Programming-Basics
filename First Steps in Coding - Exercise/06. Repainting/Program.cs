using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Четем от конзолата данни и ги записваме в променливи (вход)
            // Количество найлон - int (добавяме 2кв м)
            // Боя в литри - double (защото се умножава по проценти) (10%)
            // Разредител в литри - int
            // часовете - int
            int kolichestvoNailon = int.Parse(Console.ReadLine()) + 2; //pishem dvata tuk
            double paintInLiters = double.Parse(Console.ReadLine());
            paintInLiters = paintInLiters + paintInLiters * 0.1; //pishem procentite tuk
            int thinnerLiters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            //2. Изчисляваме цената на материалите
            double obshtoNailon = kolichestvoNailon * 1.50;
            double totalPaint = paintInLiters * 14.50;
            double totalThinner = thinnerLiters * 5.00;

            //3. Намираме общата сума
            // (найлон + разредител + 0.4 за торбичка)
            double totalSum = obshtoNailon + totalPaint + totalThinner + 0.4;

            //4. Цена за час работа (30 % от сбора на всички разходи)
            double priceForHour = totalSum * 0.3;

            //5. Намираме колко ще излезне ремонта
            // (общата сума за материали + часове работа * цена за час работа
            double totalSumForRepair = totalSum + priceForHour * hours;

            //6. Извеждаме на конзолата
            Console.WriteLine($"She trqbva da platim {totalSumForRepair} na maistorite!");

        }
    }
}
