using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_Teh9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int sum = 0;
            do
            {
                Console.Write("Enter a number: ");
                x = int.Parse(Console.ReadLine());
                sum = sum + x;
            } while (x != 0);
            Console.WriteLine("--------------------");
            Console.WriteLine("Sum= " + sum);

            Console.ReadLine();
        }
    }
}
