using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double projectsNum = double.Parse(Console.ReadLine());
            double obshtoVreme = projectsNum * 3;
            
            Console.WriteLine($"The architect {name} will need {obshtoVreme} hours to complete {projectsNum} project/s.");                                   
        }
    }
}
