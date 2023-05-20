using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());

            int money = 0; //спестяванията

            //Създаваме цикъл, който да се изпълнява за всеки рожден ден
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0) // Проверяваме дали РД е четен и добавяме към спестяванията съответната сума
                {
                    money += i * 5 - 1; // => ако е четен: получава пари = годините*5-1
                }
                else
                {
                    money += priceToy; // => ако е нечетен: получава играчка
                }
            }

            if (money >= price)
            {
                Console.WriteLine($"Yes! {money - price:F2}");
            }
            else
            {
                Console.WriteLine($"No! {price - money:F2}");
            }
        }
    }
}
