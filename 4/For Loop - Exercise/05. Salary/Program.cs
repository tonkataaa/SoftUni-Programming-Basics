using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Чета от вход
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            //2. Създаваме цикъл, който да се изпълнява за всеки сайт
            for (int i = 0; i < tabs; i++)
            {
                string website = Console.ReadLine();

                if (website == "Facebook")
                {
                    salary -= 150;
                }
                else if (website == "Instagram")
                {
                    salary -= 100;
                }
                else if (website == "Reddit")
                {
                    salary -= 50;
                }

                if (salary == 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
