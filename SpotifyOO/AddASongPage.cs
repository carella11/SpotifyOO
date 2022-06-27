using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SpotifyOO
{
    public class AddASongPage
    {
        public void AddSongInfo()
        {
            Console.WriteLine("Title: ");
            string addSongTitle = Console.ReadLine();

            Console.WriteLine("Artist: ");
            string addSongArtist = Console.ReadLine();

            Console.WriteLine("Genre: ");
            string addSongGenre = Console.ReadLine();

            Console.WriteLine("Length: ");
            string addSongLength = Console.ReadLine();

            Console.WriteLine("URL: ");
            string addSongURL = Console.ReadLine();

            Library.AddSong(addSongTitle, addSongArtist, addSongGenre, addSongLength, addSongURL);
        }

    }
}
