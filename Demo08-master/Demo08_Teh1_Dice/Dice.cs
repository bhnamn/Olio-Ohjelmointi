using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Teh1_Dice
{
    class Dice
    {
        // Filed variable
        private Random rand = new Random();

        // 0-5 +1 -> 1-6
        public int Throw()
        {
            return rand.Next(6) + 1;
        }


    }
}
