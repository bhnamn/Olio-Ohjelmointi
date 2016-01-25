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
            int[] numbers = new int[5];

            Console.WriteLine("Please enter 5 integers: ");

            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("The entered numbers are: " + numbers[4] + "," + numbers[3] + "," + numbers[2] + "," + numbers[1] + "," + numbers[0]);


            Console.ReadLine();
        }
    }
}
