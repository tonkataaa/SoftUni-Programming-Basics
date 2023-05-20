using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата данните и ги записваме в променливи:
            // Брой страници - int
            // Страници които прочита за 1 час - int
            // Броят на дните - int
            int pagesQuantity = int.Parse(Console.ReadLine());
            int pagesForHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            //2. Намираме за колко време ще прочете книгата
            // (броя страници / страниците за час = общо часове
            int obshtoChasove = pagesQuantity / pagesForHour;

            //3. Намираме колко часа на ден са необходими
            //  = часовете общо / броя дни
            int neededHours = obshtoChasove / days;

            // 4. Извеждаме резултата на конзолата
            Console.WriteLine(neededHours);
        }
    }
}
