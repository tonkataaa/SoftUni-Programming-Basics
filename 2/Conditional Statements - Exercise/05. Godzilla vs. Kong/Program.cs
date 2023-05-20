using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Godzilla_vs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Извеждам от вход
            double budget = double.Parse(Console.ReadLine());
            int satistics = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());

            //2. Правя сметките
            //сума за декор = 10% от бюджета
            double decorSum = budget * 0.10;

            //сума за облекло 
            double clothingSum = satistics * clothingPrice;


            //Ако статистите са повече от 150, има отстъпка за облеклото на стойност 10%
            double totalSum = decorSum + clothingSum;
            double moneyLeft = budget - totalSum;

            if (satistics > 150)
            {
                double clothingPrice2 = clothingSum * 0.90;
                double totalSum2 = decorSum + clothingPrice2;
                double moneyLeft2 = budget - totalSum2;

                if (totalSum2 > budget)
                {
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {Math.Abs(moneyLeft2):F2} leva more.");
                }
                else if (totalSum2 <= budget)
                {
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {moneyLeft2:F2} leva left.");
                }
            }


            else if (totalSum > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(moneyLeft):F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
            }
        }
    }
}
