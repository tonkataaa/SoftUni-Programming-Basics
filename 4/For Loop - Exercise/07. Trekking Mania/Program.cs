using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            // като 3 задача
            int groups = int.Parse(Console.ReadLine());
            double musala = 0;
            double monblan = 0;
            double kilimanjaro = 0;
            double k2 = 0;
            double everest = 0;

            for (int i = 1; i <= groups; i++)
            {
                int groupsPeople = int.Parse(Console.ReadLine());

                if (groupsPeople <= 5)
                {
                    musala += groupsPeople;
                }
                else if (6 <= groupsPeople && groupsPeople <= 12)
                {
                    monblan += groupsPeople;
                }
                else if (13 <= groupsPeople && groupsPeople <= 25)
                {
                    kilimanjaro += groupsPeople;
                }
                else if (26 <= groupsPeople && groupsPeople <= 40)
                {
                    k2 += groupsPeople;
                }
                else if (groupsPeople >= 41)
                {
                    everest += groupsPeople;
                }
            }
            double totalPeople = musala + monblan + kilimanjaro + k2 + everest;
            double musalaPeople = musala / totalPeople * 100;
            double monblanPeople = monblan / totalPeople * 100;
            double kilimanjaroPeople = kilimanjaro / totalPeople * 100;
            double k2People = k2 / totalPeople * 100;
            double everestPeople = everest / totalPeople * 100;

            Console.WriteLine($"{musalaPeople:F2}%");
            Console.WriteLine($"{monblanPeople:F2}%");
            Console.WriteLine($"{kilimanjaroPeople:F2}%");
            Console.WriteLine($"{k2People:F2}%");
            Console.WriteLine($"{everestPeople:F2}%");
        }
    }
}
