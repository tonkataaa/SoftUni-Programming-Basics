using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата
            // Дължината в см.
            double lengthInCm = double.Parse(Console.ReadLine());
            //Широчина в см.
            double widthInCm = double.Parse(Console.ReadLine());
            //Височина в см.
            double heightInCm = double.Parse(Console.ReadLine());
            //Процент 
            double percent = double.Parse(Console.ReadLine());

            //2. Да намера решенията
            //Обем
            double volume = lengthInCm * widthInCm * heightInCm;
            //Обем в литри
            double volumeInLiters = volume / 1000;
            //заето пространство
            double filledSpace = percent / 100.00;
            //нужни литри
            double neededLiters = volumeInLiters * (1 - filledSpace);

            //3. Извеждам в конзолата
            Console.WriteLine(neededLiters);

        }
    }
}
