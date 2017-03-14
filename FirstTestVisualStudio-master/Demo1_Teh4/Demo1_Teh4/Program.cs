using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_Teh4
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Please enter your age: ");
            age = int.Parse(Console.ReadLine());
            if (age < 18)
                Console.WriteLine("alaikäinen");
            else if ((age >= 18) && (age <= 65))
                Console.WriteLine("aikuinen");
            else if (age > 65)
                Console.WriteLine("seniori");
            Console.ReadLine();
                               

        }
    }
}
