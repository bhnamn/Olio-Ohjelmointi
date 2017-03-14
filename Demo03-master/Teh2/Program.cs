using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh2
{
    class Program
    {
        static void Main(string[] args)
        {
            WashingMachine washingMachine = new WashingMachine();
            washingMachine.WaterTemp = 60;
            washingMachine.SpinSpeed = 800;
            washingMachine.WashingMethod = "Normal";
            washingMachine.Prewash = true;
            washingMachine.PrintData();
            Console.WriteLine(washingMachine.ToString());

            Console.ReadLine();
        }
    }
}
