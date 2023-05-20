using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата
            int degree = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            //2.Правя проверките
            string outfit = string.Empty;
            string shoes = string.Empty;

            if (10 <= degree && degree <= 18)
            {
                if (time == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (time == "Afternoon" || time == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (18 < degree && degree <= 24)
            {
                if (time == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (time == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (time == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (degree >= 25)
            {
                if (time == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (time == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (time == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }


            Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");

        }
    }
}
