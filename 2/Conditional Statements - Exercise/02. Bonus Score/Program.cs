using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Изписсвам от вход
            int startingPoints = int.Parse(Console.ReadLine());

            //2. Изразявам бонуса
            double bonus = 0.0;

            //3. if-else-if конструкция
            if (startingPoints <= 100)
            {
                bonus = 5;
            }
            else if (startingPoints > 1000)
            {
                bonus = startingPoints * 0.1;
            }
            else
            {
                bonus = startingPoints * 0.2;
            }

            //4. Допълнителен бонус
            //ако числото е четно - 1т.
            //ако завършва на 5 --> 2т.
            if (startingPoints % 2 == 0)
            {
                bonus += 1;
            }
            else if (startingPoints % 10 == 5)
            {
                bonus += 2;
            }

            //5. Опечатваме бонуса после числото с бонуса
            Console.WriteLine(bonus);
            Console.WriteLine(startingPoints + bonus);
        }
    }
}
