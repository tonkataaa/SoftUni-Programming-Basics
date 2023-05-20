using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            foreach (char letter in text)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
