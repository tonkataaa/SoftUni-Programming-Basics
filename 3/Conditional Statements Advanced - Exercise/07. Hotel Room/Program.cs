using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studio = 0;
            double apartament = 0;

            switch (month)
            {
                case "May":
                case "October":
                    if (nights <= 7)
                    {
                        studio = 50 * nights;
                        apartament = 65 * nights;
                        Console.WriteLine($"Apartment: {apartament:f2} lv.");
                        Console.WriteLine($"Studio: {studio:f2} lv.");
                    }
                    else if (nights >= 7 && nights <= 14)
                    {
                        studio = (50 * nights) - (0.05 * 50 * nights);
                        apartament = 65 * nights;
                        Console.WriteLine($"Apartment: {apartament:f2} lv.");
                        Console.WriteLine($"Studio: {studio:f2} lv.");
                    }
                    else if (nights > 14)
                    {
                        studio = (50 * nights) - (0.3 * 50 * nights);
                        apartament = (65 * nights) - (65 * nights * 0.1);
                        Console.WriteLine($"Apartment: {apartament:f2} lv.");
                        Console.WriteLine($"Studio: {studio:f2} lv.");
                    }
                    break;
                case "June":
                case "September":
                    if (nights <= 14)
                    {
                        studio = 75.2 * nights;
                        apartament = 68.7 * nights;
                        Console.WriteLine($"Apartment: {apartament:f2} lv.");
                        Console.WriteLine($"Studio: {studio:f2} lv.");

                    }
                    else
                    {
                        studio = (75.2 * nights) - (0.2 * 75.2 * nights);
                        apartament = (68.7 * nights) - (68.7 * nights * 0.1);
                        Console.WriteLine($"Apartment: {apartament:f2} lv.");
                        Console.WriteLine($"Studio: {studio:f2} lv.");
                    }
                    break;
                case "July":
                case "August":
                    if (nights <= 14)
                    {
                        studio = 76 * nights;
                        apartament = 77 * nights;
                        Console.WriteLine($"Apartment: {apartament:f2} lv.");
                        Console.WriteLine($"Studio: {studio:f2} lv.");
                    }
                    else
                    {
                        studio = 76 * nights;
                        apartament = (77 * nights) - (77 * nights * 0.1);
                        Console.WriteLine($"Apartment: {apartament:f2} lv.");
                        Console.WriteLine($"Studio: {studio:f2} lv.");
                    }
                    break;
            }
        }
    }
}
