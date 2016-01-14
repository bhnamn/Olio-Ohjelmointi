using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_Teh6
{
    class Program
    {
        static void Main(string[] args)
        {
            double dist, x, cons, cost;

            Console.WriteLine("Enter distance: ");
            dist = double.Parse(Console.ReadLine());
            x = dist / 100;
            cons = x * 7.02;
            cost = cons * 1.595;

            Console.WriteLine("The Gasoline consumption is: " + cons + "       litre");
            Console.WriteLine("              The charge is: " + cost + "    euro");
            Console.ReadLine();
        }
    }
}
