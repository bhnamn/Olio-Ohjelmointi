using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_Teh2
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade;
            Console.WriteLine("Please enter your grade number: ");
            grade = int.Parse(Console.ReadLine());

            if ((grade >= 0) && (grade <= 1))
                Console.WriteLine("Your koulunumero is: 0");
            else if ((grade >= 2) && (grade <= 3))
                Console.WriteLine("Your koulunumero is: 1");
            else if ((grade >= 4) && (grade <= 5))
                Console.WriteLine("Your koulunumero is: 2");
            else if ((grade >= 6) && (grade <= 7))
                Console.WriteLine("Your koulunumero is: 3");
            else if ((grade >= 8) && (grade <= 9))
                Console.WriteLine("Your koulunumero is: 4");
            else if ((grade >= 10) && (grade <= 12))
                Console.WriteLine("Your koulunumero is: 5");
            else if((grade < 0) || (grade > 12))
                Console.WriteLine("Entered number is not valid!");
            
            Console.ReadLine();

        }
    }
}
