using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();
            int counter = 0;
            bool isBookFound = false;
            string nextBookName = Console.ReadLine();
            while (nextBookName != "No More Books")
            {
                if (favBook == nextBookName)
                {
                    break;
                }
                nextBookName = Console.ReadLine();
                counter++;

            }
            if (favBook == nextBookName)
            {
                Console.WriteLine($"You checked {counter} books and found it.");

            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
