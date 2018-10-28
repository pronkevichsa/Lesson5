using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    class PlayList
    {
        public List<Song> songs;

        public void Add(params Song[] songs)
        {
            this.songs = songs.ToList<Song>();
        }
    }
}
