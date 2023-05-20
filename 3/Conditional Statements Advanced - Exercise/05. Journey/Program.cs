using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = string.Empty;
            string placeToStay = string.Empty;
            double discount = 0;
            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    placeToStay = "Camp";
                    discount = budget - (budget * 0.30);
                }
                else if (season == "winter")
                {
                    placeToStay = "Hotel";
                    discount = budget - (budget * 0.70);
                }
            }
            else if (budget <= 1000 && budget > 100)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    placeToStay = "Camp";
                    discount = budget - (budget * 0.40);
                }
                else if (season == "winter")
                {
                    placeToStay = "Hotel";
                    discount = budget - (budget * 0.80);
                }
            }
            else if (budget > 1000)
            {
                placeToStay = "Hotel";
                destination = "Europe";
                discount = budget - (budget * 0.90);
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{placeToStay} - {Math.Abs(budget - discount):F2}");
        }
    }
}
