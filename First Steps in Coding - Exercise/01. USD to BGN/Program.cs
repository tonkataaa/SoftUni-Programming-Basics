using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Четем USD от конзолата
            double usd = double.Parse(Console.ReadLine());
            //2. Преобразуваме от USD в BGN (1 USD = 1.79549  BGN.)
            double bgn = usd * 1.79549;
            //3. Отпечатваме BGN на конзолата
            Console.WriteLine(bgn);
        }
    }
}
