using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            money = money * 100;
            int coinsCount = 0;
            while (money > 0)
            {
                if (money >= 200)
                {
                    money -= 200;
                }
                else if (money >= 100)
                {
                    money -= 100;
                }
                else if (money >= 50)
                {
                    money -= 50;
                }
                else if (money >= 20)
                {
                    money -= 20;
                }
                else if (money >= 10)
                {
                    money -= 10;
                }
                else if (money >= 5)
                {
                    money -= 5;
                }
                else if (money >= 2)
                {
                    money -= 2;
                }
                else if (money >= 1)
                {
                    money -= 1;
                }
                else
                {
                    money = 0;
                    break;
                }
                coinsCount++;

            }
            Console.WriteLine(coinsCount);

        }
    }
}
