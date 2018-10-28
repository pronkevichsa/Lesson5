using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    class AudioPlayer
    {
        private int _volume;
        private bool Locked;        
        public bool IsPlaying;
        public List <Song> songs;
        Song PlayingSong;

        public void Lock()
        {
            Locked = true;
            
        }
        public void Unlock()
        {
            Locked = false;
        }

        public void Play()
        {
            if (this.Locked == false) this.IsPlaying = true;
            if (PlayingSong == null) PlayingSong = songs[0];
        }

        public void Stop()
        {
            if (Locked==false)
            {
                IsPlaying = false;
            }
        }
        public int Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                if (value < 0) _volume = 0;
                else if (value > 100) _volume = 100;
                else _volume = value;
            }
        }

        public void VolumeUp()
        {
            //Volume++;
            Volume = Volume + 1;
        }

        public void VolumeDown()
        {
            //Volume--;
            Volume = Volume-1;
        }

        public void VolumeChange(int step)
        {
            //Volume--;
            Volume += step;
        }

        public void Add(Song song)
        {
            this.songs.Add(song);
        }

        public void Add(PlayList playList)
        {
            this.songs = playList.songs;
        }

        public void Add (Artist artist)
        {
            this.songs = artist.Songs;
        }


    }
}
