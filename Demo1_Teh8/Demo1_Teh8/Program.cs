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
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
           
            if (b > a)
            {
                a = b; 
            }
            //Console.WriteLine(a + "," + b + "," + c);
            if (c > b)
            {
                b = c;  
            }
            //Console.WriteLine(a + "," + b + "," + c);
            if (b > a)
            {
                a = b;   
            }
            //Console.WriteLine(a + "," + b + "," + c);
            Console.WriteLine("The biggest number is " + a);

            Console.ReadLine();
        }
    }
}
