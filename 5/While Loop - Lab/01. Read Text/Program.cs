using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Read_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (text != "Stop")
            {
                Console.WriteLine(text);
                text = Console.ReadLine();


            }
        }
    }
}
