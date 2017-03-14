using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_Teh3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, sum, average;

            Console.WriteLine("Please enter 3 integer numbers: ");
            Console.WriteLine("Enter 1st number: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd number: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("You have entered: " + a +" " + b +" " + c);
            sum = a + b + c;
            average = sum / 3;
             
            Console.WriteLine("Sum= " +a+"+"+b+"+"+c+"= "+sum );
            Console.WriteLine("Average= " + average);

            Console.ReadLine();

        }
    }
}
