using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Teh05
{
    class Volume
    {
        private readonly int minVol = 0, maxVol = 9;

        private int vol;
        public int Vol
        {
            get
            {
                return vol;
            }
            set
            {
                if ((value <= maxVol)|| (value > minVol))
                {
                    vol = value;
                }
                else if (value == minVol)
                {
                    Console.WriteLine("Muted");
                }
            }
        }
    }
}