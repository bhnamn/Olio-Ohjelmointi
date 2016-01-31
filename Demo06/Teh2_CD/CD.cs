using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh2_CD
{
    class CD
    {
        private List<Song> songList;
        public string CdName { get; set; }
        
        public CD()
        {
            songList = new List<Song>();
        }

        public void AddSong(Song song)
        {
            songList.Add(song);
        }

        public void PrintSongList()
        {
            Console.WriteLine("CD data:");
            Console.WriteLine("Album name: " + CdName);
            foreach (Song song in songList)
            {
                Console.WriteLine(song.ToString());

            }
        }
    }
}
