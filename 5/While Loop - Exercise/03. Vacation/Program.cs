using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            string input;
            double money;
            int daysCount = 0;
            int spedCount = 0;
            while (budget < neededMoney)
            {
                input = Console.ReadLine();
                money = double.Parse(Console.ReadLine());
                daysCount++;
                if (input == "save")
                {
                    budget += money;
                    spedCount = 0;
                }
                else
                {
                    spedCount++;
                    if (spedCount == 5)
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine(daysCount);
                        break;
                    }
                    else
                    {
                        budget -= money;
                        if (budget < 0)
                        {
                            budget = 0;
                        }
                    }
                }

            }
            if (budget >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }

        }
    }
}
