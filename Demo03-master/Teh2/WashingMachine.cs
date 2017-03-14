using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh2
{
    class WashingMachine
    {
        public int WaterTemp { get; set; }
        public int SpinSpeed { get; set; }
        public string WashingMethod { get; set; }
        public bool Prewash { get; set; }
        //method print washing mashine datas
        public void PrintData()
        {
            Console.WriteLine("Washing machine prog.: ");
            Console.WriteLine("-Water temp: "+WaterTemp);
            Console.WriteLine("-Spin speed: " + SpinSpeed);
            Console.WriteLine("-Washing method: " + WashingMethod);
            Console.WriteLine("-Prewash: " + Prewash);

        }
        public override string ToString()
        {
            return "WaterTemp: "+ WaterTemp+ ", SpinSpeed: "+ SpinSpeed+ ", WashingMethod: "+ WashingMethod+ ", Prewash: "+ Prewash;
        }
    }
}
