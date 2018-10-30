using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    class Song
    {
        //comment 3
        public string Title;
        public string Lyrics;
        public int Duration;
        public Artist Artist; 
        public Album Album;

        public Song(string title = "First", string lirycs = "none", int duration = 0)
        {
            this.Title = title;
            this.Lyrics = lirycs;
            this.Duration = duration;
        }

        //public System.Nullable<bool> Like { get; set; }        
    }
}
