using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    class Artist
    {
        public string Name;

        public List<Song> Songs;

        public Album[] Albums;
        public Artist()
        {

        }
        public Artist(string Name)
        {
            this.Name = Name;
        }
    }
}
