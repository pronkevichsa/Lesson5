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

        public bool Play(out Song playingSong)
        {
            
            if (this.Locked == false) this.IsPlaying = true;
            if (PlayingSong == null) PlayingSong = songs[0];
            playingSong = PlayingSong;
            return true;
        }

        public bool Play(out Song playingSong, bool loop=false)
        {

            if (this.Locked == false) this.IsPlaying = true;
            if (PlayingSong == null) PlayingSong = songs[0];
            playingSong = PlayingSong;
            int cycles = loop ? 5 : 1;
            for (int i = 0; i < cycles; i++)
            {
                foreach (var song in this.songs)
                {
                    PlayingSong = song;

                    //Console.Clear();

                    //ListSongs();
                    //Console.WriteLine(PlayingSong.Title + ": " + PlayingSong.Lyrics);

                    //System.Threading.Thread.Sleep(2000);
                }
            }
            return true;
        }

        public void Stop()
        {
            if (Locked==false)
            {
                IsPlaying = false;
            }
        }

        public bool Stop(out Song playingSong)
        {
            playingSong = null;
            return true;
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
        public void Add(Album album)
        {
            this.songs = album.Songs;
        }

        public void Shuffle()
        {
            List<Song> suffledSongs = new List<Song>();
            int step = 4;
            for (int i = 0; i < step; i++)
            {
                int index = i;

                while (index < songs.Count)
                {
                    suffledSongs.Add(songs[index]);
                    index += step;
                }
            }

            songs = suffledSongs;
        }

        public void SortByTitle()
        {
            List<string> names = new List<string>();
            List<Song> sorted = new List<Song>();

            foreach (var song in this.songs)
            {
                names.Add(song.Title);
            }

            names.Sort();
            foreach (var name in names)
            {
                foreach (var song in this.songs)
                {
                    if (song.Title == name)
                    {
                        sorted.Add(song);
                        continue;
                    }
                }
            }

            this.songs = sorted;
        }
    }
}
