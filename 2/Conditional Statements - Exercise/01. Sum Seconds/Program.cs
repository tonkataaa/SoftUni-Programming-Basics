using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Прочитам от вход времето им
            int firstFinish = int.Parse(Console.ReadLine());
            int secondFinish = int.Parse(Console.ReadLine());
            int thirdFinish = int.Parse(Console.ReadLine());

            //2. Намирам им общото време
            int totalTime = firstFinish + secondFinish + thirdFinish;

            //3. Колко минути и колко секунди им е общото време
            int minutes = totalTime / 60; // 110/60=1  ---> Коклко пъти 60 се съдържа (50 остатък)
            int seconds = totalTime % 60; // 110%60 = 50 ---> колко пъти 60 не се съдържа


            //4. Извеждаме резултата на конзолата
            // проверяваме дали секундите са <10
            if (seconds < 10) // секундите = 0/1/2/3/4/5/6/7/8/9
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
