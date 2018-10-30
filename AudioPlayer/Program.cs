using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new AudioPlayer();

            Song[] song = CreateSongs();

            player.songs = song.ToList<Song>();

            player.SortByTitle();
            player.Add(song[0]);
            player.Play(out song[0]);
            foreach (Song currentSong in player.songs)
            {
                Console.WriteLine(currentSong.Lyrics);
            }
            player.Shuffle();
            foreach (Song currentSong in player.songs)
            {
                Console.WriteLine(currentSong.Lyrics);
            }
            Console.ReadLine();
        }

        private static Song[] CreateSongs()
        {
            return new Song[] {
                new Song()
                {
                    Title = "The King of Magic",
                    Duration = 300,
                    Lyrics = @"Friends Will Be Friends",
                    Album = null,
                    Artist = null                    
                },
                new Song()
                {
                    Title = "The King of Magic",
                    Duration = 300,
                    Lyrics = @"Who Wants to Live Forever",
                    Album = null,
                    Artist = null
                    
                },
                new Song()
                {
                    Title = "The King of Magic",
                    Duration = 400,
                    Lyrics = @"Princes of the Universe",
                    Album = null,
                    Artist = null
                },
                new Song()
                {
                    Title = "Innuendo",
                    Duration = 300,
                    Lyrics = @"The Show Must Go On",
                    Album = null,
                    Artist = null
                },
                new Song()
                {
                    Title = "Innuendo",
                    Duration = 300,
                    Lyrics = @"I'm Going Slightly Mad",
                    Album = null,
                    Artist = null
                }
            };
        }
    }
}
