using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh01
{
    class Program
    {
        static void Main(string[] args)
        {
            // create tyer
            Tyre tyre1 = new Tyre { Name = "Nokia", Model = "Hakka", TyreSize = "205R16" };
            Tyre tyre2 = new Tyre { Name = "Continental", Model = "Fast", TyreSize = "225R16" };

            //create car
            Vehicle car = new Vehicle { Name = "Porche", Model = "911" };
            car.AddTyre(tyre1); //car contains tyres...
            car.AddTyre(tyre2); //car contains tyres...

            Console.WriteLine(car.ToString());

            Console.WriteLine("press enter to continue...");
            Console.ReadLine();



        }
    }
}
