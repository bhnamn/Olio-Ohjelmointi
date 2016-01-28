using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh2_CD
{
    class Song
    {
        public string SongName { get; set; }
        public string Artist { get; set; }
        public string Length { get; set; }

        public Song()
        {
            SongName = "Default";
            Artist = "Default";
            Length = "Default";
        }

        public override string ToString()
        {
            return "-Song name: " + SongName + " -Artist: " + Artist + " -Length: " + Length;
        }

    }
}
