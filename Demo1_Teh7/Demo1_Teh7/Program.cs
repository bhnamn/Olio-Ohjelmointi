using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_Teh7
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Which year? > ");
            year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0) && (year % 100 != 0))
                Console.WriteLine("The year " + year + " is a leap year");
            else if ((year % 100 == 0) && (year % 400 == 0))
                Console.WriteLine("The year " + year + " is a leap year");
            else
                Console.WriteLine("The year " + year + " is not a leap year");

            Console.ReadLine();
        }
    }
}
