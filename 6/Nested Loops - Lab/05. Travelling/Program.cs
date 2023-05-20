using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Създаваме променливи за:
            // - вход от конзолата
            string input = Console.ReadLine();
            // - дестинация
            string destination;
            // - необходим бюджет
            double budget;


            //3. Създаваме while цикъл, който да се изпълнява, докато входът != "End"
            while (input != "End")
            {
                // => просвояваме на дестинация = вход
                destination = input;

                // => четем необходим бюджет за конкретната дестинация
                budget = double.Parse(Console.ReadLine());

                //=> Създаваме вътрешен while цикъл, който да се изпълнява, докато не спести достатъчно
                while (budget > 0)
                {
                    // ==> изваждаме от необходим бюджет парите, които спестява
                    budget -= double.Parse(Console.ReadLine());
                }
                //=> След като спести достатъчно - отпечатваме:
                Console.WriteLine($"Going to {destination}!");

                //=> четем нов вход от конзолата
                input = Console.ReadLine();
            }
        }
    }
}
