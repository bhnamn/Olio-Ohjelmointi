using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh04_Enrolment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create class
            Class tyre1 = new Class { Name = "Nokia", Model = "Hakka", TyreSize = "205R16" };
            Class tyre2 = new Class { Name = "Continental", Model = "Fast", TyreSize = "225R16" };

            //create course
            Course car = new Course { Name = "Porche", Model = "911" };
            car.AddClass(newClass1); //car contains tyres...
            car.AddClass(newClass2); //car contains tyres...

            Console.WriteLine(car.ToString());

            Console.WriteLine("press enter to continue...");
            Console.ReadLine();
        }
    }
}
