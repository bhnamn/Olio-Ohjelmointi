using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_CarApplication
{
    class Car
    {
        // Fields
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        private int speed;
        public bool Turbo { get; set; }
        public int DoorCount { get; set; }

        // Property(making limit for speed value)
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value >= 0 && value <= 200) { speed = value; }
                else speed = 0;
            }
        }

        // Making a default constractor to
        // coresponding the toyota object in the clint code
        public Car()
        {
            
        }

        // Making a parametric costructor
        public Car(string model)
        {
            Model = model;
        }
        
        // Method to speed up
        public void Accelerator()
        {
            Speed += 5;
        }

        // Method to slow down
        public void Brake()
        {
            Speed -= 5;
        }

        // Method to display car datas
        public void PrintData()
        {
            Console.WriteLine("Car Data: ");
            Console.WriteLine("- model : "+ Model);
            Console.WriteLine("- color : " + Color);
            Console.WriteLine("- engine : " + Engine+" Litre");
            Console.WriteLine("- speed : " + Speed + " Km/h");
            Console.WriteLine("- turbo : " + Turbo);
            Console.WriteLine("- door count : " + DoorCount);
        }
    }
}
