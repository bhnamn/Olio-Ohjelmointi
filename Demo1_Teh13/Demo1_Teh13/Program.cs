using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_Teh13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, min, max, sum;

            Console.WriteLine("Please enter the 5 result numbers: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            if (a > b)
            {
                max = a;
                min = b;
            }
            else
            {
                max = b;
                min = a;
            }
            if (c > max) max = c;
            else if (c < min) min = c;

            if (d > max) max = d;
            else if (d < min) min = d;

            if (e > max) max = e;
            else if (e < min) min = e;

            sum = a + b + c + d + e - min - max;
            Console.WriteLine("The total point is: " + sum);

            Console.ReadLine();
        }
    }
}
