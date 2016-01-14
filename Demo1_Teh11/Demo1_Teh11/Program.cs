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
            int row;
            Console.Write("Enter row number: ");
            row = int.Parse(Console.ReadLine());

            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < row; j++)
                {
                    
                    Console.WriteLine(j);
                }
            }
                

            Console.ReadLine();

        }
    }
}
