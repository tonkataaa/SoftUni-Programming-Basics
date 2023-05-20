using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 0;

            string input;
            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                double depositAmount = double.Parse(input);
                if (depositAmount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                balance += depositAmount;
                Console.WriteLine($"Increase: {depositAmount:F2}");
            }

            Console.WriteLine($"Total: {balance:F2}");
        }
    }
}
