using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int final = int.Parse(Console.ReadLine());


            for (int num = start; num <= final; num++)
            {
                int chetni = 0;
                int neChetni = 0;

                string currentNum = num.ToString();
                for (int j = 0; j < 6; j++)
                {




                    if (j % 2 == 0)
                    {
                        chetni += currentNum[j];
                    }

                    else
                    {
                        neChetni += currentNum[j];

                    }



                }


                if (neChetni == chetni)
                {
                    Console.Write($"{num} ");
                }



            }
        }
    }
}
