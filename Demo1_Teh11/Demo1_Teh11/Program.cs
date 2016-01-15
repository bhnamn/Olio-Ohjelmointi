using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_Teh11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, row;
            Console.Write("Enter row number: ");
            row = int.Parse(Console.ReadLine());

            for (i = 1; i <= row; i++)
            {
                Console.WriteLine("");
                for (j = 0; j < i; j++)
                    Console.Write("*");
            }

            Console.ReadLine();

        }
    }
}
