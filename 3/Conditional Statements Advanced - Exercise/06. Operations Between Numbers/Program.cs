using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = int.Parse(Console.ReadLine());
            double number2 = int.Parse(Console.ReadLine());
            char op = char.Parse(Console.ReadLine());

            double result = 0;
            string even = "even";
            string odd = "odd";
            if (op == '+')
            {
                result = number1 + number2;

                if (result % 2 == 0)
                {

                    Console.WriteLine($"{number1} + {number2} = {result} - {even}");
                }
                else
                {
                    Console.WriteLine($"{number1} + {number2} = {result} - {odd}");
                }
            }
            else if (op == '-')
            {
                result = number1 - number2;
                if (result % 2 == 0)
                {

                    Console.WriteLine($"{number1} - {number2} = {result} - {even}");
                }
                else
                {
                    Console.WriteLine($"{number1} - {number2} = {result} - {odd}");
                }
            }
            else if (op == '*')
            {
                result = number1 * number2;
                if (result % 2 == 0)
                {

                    Console.WriteLine($"{number1} * {number2} = {result} - {even}");
                }
                else
                {
                    Console.WriteLine($"{number1} * {number2} = {result} - {odd}");
                }
            }
            else if (op == '/')
            {
                result = number1 / number2;


                if (number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }
                else
                {
                    Console.WriteLine($"{number1} / {number2} = {result:F2}");
                }

            }
            else if (op == '%')
            {
                result = number1 % number2;

                if (number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }
                else
                {
                    Console.WriteLine($"{number1} % {number2} = {result}");
                }
            }
        }
    }
}
