using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sumPrime = 0;
            int sumNonPrime = 0;

            int num = 0;
            bool isPrime;
            while (input != "stop")
            {
                num = int.Parse(input);
                isPrime = true;
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                }


                else
                {
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }



                if (isPrime && num > 0)
                {

                    sumPrime += num;
                }

                else if (num > 0)
                {
                    sumNonPrime += num;
                }

                input = Console.ReadLine();


            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");

        }
    }
}
