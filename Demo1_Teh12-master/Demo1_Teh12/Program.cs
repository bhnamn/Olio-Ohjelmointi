using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_Teh12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test= new int[5];

            Console.WriteLine("Please enter 5 integers: ");

            for (int i = 0; i < 5; i++)
                test[i]= int.Parse(Console.ReadLine());
            for (int j = 0; j < test.Length; j++)
                Console.Write(test[j]+","); ;

            Console.ReadLine();

        }
    }
}
