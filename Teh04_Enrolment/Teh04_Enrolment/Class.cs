using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh04_Enrolment
{
    class Class
    {
        public string Day { get; set; }
        public string Hour { get; set; }
        public string Classroom { get; set; }

        public override string ToString()
        {
            return "Day: " + Day + "Hour: " + Hour + "Classroom: " + Classroom;
        }
    }
}
