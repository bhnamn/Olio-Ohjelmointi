using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh2_CD
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a collection
            List<CD> CdList = new List<CD>();

            // create & initializing objects from CD
            CD CD1 = new CD { CdName="xxx"};
            CD CD2 = new CD { CdName = "zzz" };

            // create an object from CD
            Song song1 = new Song { SongName = "aaa", Artist = "bbb", Length = "ccc" };
            Song song2 = new Song { SongName = "ddd", Artist = "fff", Length = "ggg" };
            Song song3 = new Song { SongName = "hhh", Artist = "jjj", Length = "kkk" };
            Song song4 = new Song { SongName = "hhh", Artist = "jjj", Length = "kkk" };
            Song song5 = new Song { SongName = "hhh", Artist = "jjj", Length = "kkk" };
            Song song6 = new Song { SongName = "hhh", Artist = "jjj", Length = "kkk" };



            CD1.AddSong(song1);
            CD1.AddSong(song2);
            CD1.AddSong(song3);

            CD2.AddSong(song4);
            CD2.AddSong(song5);
            CD2.AddSong(song6);

            CdList.Add(CD1);
            CdList.Add(CD2);

            foreach(CD disck in CdList)
            {
                disck.PrintSongList();
            }

            
        }
    }
}
