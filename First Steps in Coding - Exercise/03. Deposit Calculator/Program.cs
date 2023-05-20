using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Четем от конзолата данните и ги запазваме в съответните променливи: 
            // Депозирана сума - double
            // Срок на депозита - int
            // Годишен лихвен процент - double
            double deposit = double.Parse(Console.ReadLine());
            int depositTerm = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine()) / 100;

            //2. Изчисляваме сумата чрез формулата (сума = депозирана сума  + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
            double sum = deposit + depositTerm * ((deposit * annualInterestRate) / 12);

            //3. Да изведем на конзолата
            Console.WriteLine(sum);

        }
    }
}
