using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());

            double priceShip = 0;
            double discount = 0;

            if (season == "Spring")
            {
                priceShip = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                priceShip = 4200;
            }
            else if (season == "Winter")
            {
                priceShip = 2600;
            }
            if (fishers <= 6)
            {

                priceShip *= 0.90;
            }
            else if (fishers >= 7 && fishers <= 11)
            {
                priceShip *= 0.85;
            }
            else if (fishers >= 12)
            {
                priceShip *= 0.75;
            }
            if (fishers % 2 == 0 && season != "Autumn")
            {
                priceShip *= 0.95;
            }

            double total = priceShip;
            if (total > budget)
            {
                double moneyNeeded = total - budget;
                Console.WriteLine($"Not enough money! You need {Math.Abs(moneyNeeded):f2} leva.");
            }
            else if (total <= budget)
            {
                double moneyLeft = budget - total;
                Console.WriteLine($"Yes! You have {Math.Abs(moneyLeft):F2} leva left.");
            }
        }
    }
}
