using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Teh05
{
    class Volume
    {
        private readonly int MaxVolume = 9;

        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= MaxVolume) volume = value;
                else
                {
                    Console.WriteLine("Too much volume - set to maximum!");
                    volume = MaxVolume;
                }
            }
        }
    }
}
