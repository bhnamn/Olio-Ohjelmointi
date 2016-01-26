using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh01
{
    class Vehicle
    {
        public string Name;
        public string Model;
        public List<Tyre> Tyres { get; }

        public Vehicle()
        {
            Tyres = new List<Tyre>();
        }

        public void AddTyre(Tyre tyre)
        {
            Tyres.Add(tyre);
        }

        public override string ToString()
        {
            string sVehicle = "Vehicle name: "+ Name + "Model: "+ Model + "Tyres: \n";
            foreach(Tyre tyre in Tyres)
            {
                sVehicle += tyre.ToString() + "\n";
            }
            return sVehicle;
        }
    }
}
