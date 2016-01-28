using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Teh05
{
    class Frequency
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
    }
}