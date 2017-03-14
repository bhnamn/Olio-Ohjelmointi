using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_Teh5
{
    class Program
    {
        static void Main(string[] args)
        {
            int time, sec, min, hour;
            Console.WriteLine("Enter time in seconds: ");
            time = int.Parse(Console.ReadLine());
            hour = time / 3600;
            min = (time % 3600) / 60;
            sec = hour % 60;
            Console.WriteLine("Time= " +hour+ " hours " +min+ " minutes " +sec+ " seconds");
            Console.ReadLine();

        }
    }
}
