using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyOO
{
    public class SongInfo
    {
        public string SongTitle { get; private set; }
        public string SongArtist { get; private set; }
        public string SongGenre { get; private set; }
        public string SongLength { get; private set; }
        public string SongURL { get; private set; }

        public SongInfo(string aSongTitle, string aSongArtist, string aSongGenre, string aSongLength, string aSongURL)
        {
            SongTitle = aSongTitle;
            SongArtist = aSongArtist;
            SongGenre = aSongGenre;
            SongLength = aSongLength;
            SongURL = aSongURL;
        }

        public void printInfo(int id)
        {
            Console.WriteLine("******************************");
            Console.WriteLine($"ID:      {id}");
            Console.WriteLine($"Title:   {SongTitle} ");
            Console.WriteLine($"Artist:  {SongArtist}");
            Console.WriteLine($"Genre:   {SongGenre} ");
            Console.WriteLine($"Length:  {SongLength}");
            
        }
    }
}
