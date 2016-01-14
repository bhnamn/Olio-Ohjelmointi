using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_Teh8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, x, y, z;
            Console.WriteLine("Please enter 3 integer numbers: ");
            a = x = int.Parse(Console.ReadLine());
            b = y = int.Parse(Console.ReadLine());
            c = z = int.Parse(Console.ReadLine());

            if (b > a)
            {
                a = y;
                b = x;
            }
            Console.WriteLine(a + "," + b + "," + c);
            if (c > b)
            {
                b = z;
                c = x;
            }
            Console.WriteLine(a + "," + b + "," + c);
            if (b > a)
            {
                a = z;
                b = y;
            }
            Console.WriteLine(a + "," + b + "," + c);
            Console.WriteLine("The biggest number is " + a);

            Console.ReadLine();
        }
    }
}
