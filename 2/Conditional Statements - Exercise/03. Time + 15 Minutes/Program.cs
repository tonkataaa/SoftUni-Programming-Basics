using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата часове и минути
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            //2. Обръаме часовете в минути и да ги прибавим към мин.
            // min = min + hours*60
            minutes += hours * 60;

            //3. Добавяме 15мин към останалите
            minutes += 15;

            //4. Обръщаме мин към часове и минути
            hours = minutes / 60;
            minutes = minutes % 60;

            //5. Проверяваме дали часовете не са станали =24, ако са => =0
            if (hours == 24)
            {
                hours = 0;
            }

            //6. Отпечатваме резултата във формат: часове:минути
            Console.WriteLine($"{hours}:{minutes:D2}");

        }
    }
}
