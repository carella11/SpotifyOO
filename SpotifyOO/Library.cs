using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using WMPLib;

namespace SpotifyOO
{
    public class Library
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        
        public static SongInfo[] CreateSongs =
        {
            new SongInfo("Don't Wanna Miss a Thing", "Aerosmith", "Classic Rock", "4:20", @"C:\Users\GET Academy\Desktop\Modul 3 Prosjekter\SpotifyOO\SpotifyOO\Songs\Aerosmith - I Don't Want to Miss a Thing.mp3"),
            new SongInfo("Water", "BAYNK", "EDM", "2:50", @"C:\Users\GET Academy\Desktop\Modul 3 Prosjekter\SpotifyOO\SpotifyOO\Songs\BAYNK - Water.mp3"),
            new SongInfo("Sandra's Rose", "Drake", "Rap", "3:13", @"C:\Users\GET Academy\Desktop\Modul 3 Prosjekter\SpotifyOO\SpotifyOO\Songs\Sandra’s Rose.mp3"),
            new SongInfo("Lost Ones", "J. Cole", "Hip-hop", "4:15", @"C:\Users\GET Academy\Desktop\Modul 3 Prosjekter\SpotifyOO\SpotifyOO\Songs\J. Cole – Lost Ones.mp3"),
            new SongInfo("You Make My Dreams Come True", "Daryll Hall & John Oats", "Oldies", "3:03", @"C:\Users\GET Academy\Desktop\Modul 3 Prosjekter\SpotifyOO\SpotifyOO\Songs\Daryl Hall & John Oates - You Make My Dreams.mp3"),
            new SongInfo("Who Shot Ya?", "The Notorious B.I.G", "Rap", "5:19", @"C:\Users\GET Academy\Desktop\Modul 3 Prosjekter\SpotifyOO\SpotifyOO\Songs\The Notorious B.I.G. - Who Shot Ya.mp3"),
            new SongInfo("Let It Be", "The Beatles", "Oldies", "2:69", @"C:\Users\GET Academy\Desktop\Modul 3 Prosjekter\SpotifyOO\SpotifyOO\Songs\The Beatles - Let it be.mp3"),
            new SongInfo("Never Gonna Give You Up", "Rick Astley", "80's Pop", "3:33", @"C:\Users\GET Academy\Desktop\Modul 3 Prosjekter\SpotifyOO\SpotifyOO\Songs\Rick Astley - Never Gonna Give You Up.mp3"),
            new SongInfo("Nothin' But a G Thang", "Dr. Dre & Snoop Dogg", "Rap", "4:00", @"C:\Users\GET Academy\Desktop\Modul 3 Prosjekter\SpotifyOO\SpotifyOO\Songs\Dr. Dre & Snoop Dogg - Nuthin' But A G Thang.mp3"),
        };

        public static List<SongInfo> songList = new List<SongInfo>(CreateSongs);

        public void Show()
        {
            var id = 0;
            foreach (var Songs in songList)
            {
                Songs.printInfo(id);
                id++;
            }
            var MenuTextPage = new MenuTextPage();
            Console.WriteLine("Press b for Main Menu");
            var menuChoice = Console.ReadLine();
            if (menuChoice == "b")
            {
                Console.Clear();
            }
        }

        public static void AddSong(string addSongTitle, string addSongArtist, string addSongGenre, string addSongLength, string addSongURL)
        {
            songList.Add(new SongInfo(addSongTitle, addSongArtist, addSongGenre, addSongLength, addSongURL));
        }

        public static void RemoveSong(int id)
        {
            songList.RemoveAt(id);
        }

        /*   public void PlaySong(int id)
           {
               string songURL = songList[id].SongURL;
               string songTitle = songList[id].SongTitle;
               player.URL = songURL;
               player.controls.play();
               Console.Clear();
               Console.WriteLine($"Now playing: {songTitle}");
               Console.WriteLine("Press 1 to stop the music and go back to the menu.");
               var menuChoice = Console.ReadLine();
               if (menuChoice == "1")
               {
                   player.controls.stop();
               }
           }*/
    }
}