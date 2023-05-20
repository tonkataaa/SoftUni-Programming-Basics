using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата
            double budget = double.Parse(Console.ReadLine());
            int videoCard = int.Parse(Console.ReadLine());
            int processor = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            //2. Намирам сумите
            //сума за видеокарта
            double videoCardSum = videoCard * 250;

            //цената на процесор и после сума
            double processorPrice = videoCardSum * 0.35;
            double processorSum = processorPrice * processor;

            //цената на рам памет и сума
            double ramPrice = videoCardSum * 0.10;
            double ramSum = ramPrice * ram;

            //3. Намирам общата сума
            double totalSum = videoCardSum + processorSum + ramSum;

            //4. Броя на видеокартите е по-голям от броя на процесорите, затова той получава 15% отстъпка от крайната цена
            if (videoCard > processor)
            {
                double otstupka = totalSum - (totalSum * 0.15);
                if (otstupka <= budget)
                {
                    Console.WriteLine($"You have {budget - otstupka:F2} leva left!");
                }
                else if (otstupka > budget)
                {
                    Console.WriteLine($"Not enough money! You need {otstupka - budget:F2} leva more!");
                }

            }
            else if (totalSum <= budget)
            {
                Console.WriteLine($"You have {budget - totalSum:F2} leva left!");
            }
            else if (totalSum > budget)
            {
                Console.WriteLine($"Not enough money! You need {totalSum - budget:F2} leva more!");
            }
        }
    }
}
