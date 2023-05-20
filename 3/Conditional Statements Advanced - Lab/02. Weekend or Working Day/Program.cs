using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Weekend_or_Working_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            string weekDay = Console.ReadLine();

            switch (weekDay)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
