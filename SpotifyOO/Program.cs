using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using WMPLib;

namespace SpotifyOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            var PlayList = new PlayList();
            var Library = new Library(); 
            var AddASongPage = new AddASongPage();
            var MenuTextPage = new MenuTextPage();
              
            while (true)
            {
                MenuTextPage.menuText();
                
                var menuAction = Console.ReadLine();
                Console.Clear();
                
                if (menuAction == "1")
                {
                   Console.WriteLine("Library");
                   //Console.WriteLine("5. Shuffle");
                   Library.Show();
                   //Console.WriteLine("What Song ID do you want to listen to?");
                  // Library.PlaySong(Convert.ToInt32(Console.ReadLine()));

                }
                else if (menuAction == "2")
                {
                    Console.WriteLine("PlayList");
                    PlayList.Show();
                    Console.WriteLine("What Song ID do you want to listen to?");
                    PlayList.PlaySongPL(Convert.ToInt32(Console.ReadLine()));
                }
                else if (menuAction == "3")
                {
                    Console.WriteLine("Press 1 to add a song to Library, 2 for Playlist");
                    menuAction = Console.ReadLine();

                    if (menuAction == "1") AddASongPage.AddSongInfo();
                    if (menuAction == "2")
                    {
                        Console.WriteLine("What is the ID of the song?");
                        PlayList.addSongToPLaylist(Convert.ToInt32(Console.ReadLine()));
                    }
                }
                else if (menuAction == "4")
                {
                    Console.WriteLine("Please enter ID to remove a song");
                    Library.RemoveSong(Convert.ToInt32(Console.ReadLine()));
          
                }
                else
                {
                    Console.WriteLine("Wrong command");
                }

            }
            //  var menuAction = Console.ReadLine();

            //Console.WriteLine("Push A to Add a Song To a Playlist");
            // Console.WriteLine("Push X to Remove a Song From Library");
            // Console.ReadLine();


        }
        
    }
}
