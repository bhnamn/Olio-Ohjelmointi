using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Teh05
{
    class Radio
    {
        private readonly double minFreq = 2000.0, maxFreq = 26000.0;

        private double freq;
        public double Freq
        {
            get
            {
                return freq;
            }
            set
            {
                if ((value <= minFreq) || (value >= maxFreq))
                {
                    freq = value;
                }
            }
        }

        private readonly int minVol = 0, maxVol = 9;

        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if ((value <= maxVol) || (value > minVol))
                {
                    volume = value;
                }
                else if (value == minVol)
                {
                    Console.WriteLine("Muted");
                }
            }
        }

        public bool IsOn { get; set; }
    }
}
