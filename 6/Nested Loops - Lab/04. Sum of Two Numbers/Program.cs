using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата начало и край на диапазона
            //2. Четем от конзолата магическо число
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            // Създаваме променлива, която пази броя на всички комбинации, които сме опитали
            double combination = 0;
            bool flag = false;

            //3. Създаваме вложени цикли, които да търсят всички възможни комбинации в диапазона
            for (int x1 = start; x1 <= end; x1++)
            {
                for (int x2 = start; x2 <= end; x2++)
                {
                    // => увеличаваме брояча на комбинациите с 1
                    combination++;

                    // => ще намираме сборът на числата от всяка комбинация
                    int result = x1 + x2;

                    // => проверяваме дали сборът е = магическото число
                    if (result == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combination} ({x1} + {x2} = {magicNum})");
                        flag = true;
                        break;
                    }
                    // => ако е:
                    // ==> отпечатваме: o	"Combination N:{пореден номер} ({първото число} + {второ число} = {магическото число})"
                    // =>  спираме програмата (спираме вътрешния и вънишния цикъл)
                }
                if (flag)
                {
                    break;
                }
            }

            //4. Проверяваме дали сме намерили магическа комбинация
            if (flag == false)
            {
                // => ако не сме - отпечатваме
                Console.WriteLine($"{combination} combinations - neither equals {magicNum}");
            }
        }
    }
}
