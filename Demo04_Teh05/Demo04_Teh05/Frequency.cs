using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Teh05
{
    class Frequency
    {
        private readonly double frequency (>=2000.0 || <=26000.0);

        private int speed;
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value <= MaxSpeed) speed = value;
                else
                {
                    Console.WriteLine("Too much speed - set to maximum!");
                    speed = MaxSpeed;
                }
            }
        }
    }
}
