using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            string flowersType = Console.ReadLine();
            int flowersQuantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            // Prices
            double rosesPrice = 5 * flowersQuantity;
            double dahliasPrice = 3.80 * flowersQuantity;
            double tulipsPrice = 2.80 * flowersQuantity;
            double narcissusPrice = 3 * flowersQuantity;
            double gladiolusPrice = 2.50 * flowersQuantity;
            double totalPrice = 0;

            if (flowersType == "Roses")
            {
                totalPrice = rosesPrice;

                if (flowersQuantity > 80)
                {
                    totalPrice *= 0.9;
                }

            }
            else if (flowersType == "Dahlias")
            {
                totalPrice = dahliasPrice;

                if (flowersQuantity > 90)
                {
                    totalPrice = dahliasPrice * 0.85;
                }

            }
            else if (flowersType == "Tulips")
            {
                totalPrice = tulipsPrice;

                if (flowersQuantity > 80)
                {
                    totalPrice = tulipsPrice * 0.85;
                }
            }
            else if (flowersType == "Narcissus")
            {
                totalPrice = narcissusPrice;
                if (flowersQuantity < 120)
                {
                    totalPrice = narcissusPrice * 1.15;
                }
            }
            else if (flowersType == "Gladiolus")
            {
                totalPrice = gladiolusPrice;

                if (flowersQuantity < 80)
                {
                    totalPrice = gladiolusPrice * 1.20;
                }
            }
            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {flowersQuantity} {flowersType} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {Math.Abs(moneyNeeded):f2} leva more.");
            }
        }
    }
}
