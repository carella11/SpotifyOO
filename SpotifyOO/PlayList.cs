using System;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization.Formatters;
using System.Threading.Channels;
using System.Collections.Generic;
using SpotifyOO;
using WMPLib;


public class PlayList
{
    public static List<SongInfo> PlaylistOfSongs = new List<SongInfo>();
    WMPLib.WindowsMediaPlayer playListPlayer = new WMPLib.WindowsMediaPlayer();

    public static void Show()
    {
        var id = 0;
        foreach (var Songs in PlaylistOfSongs)
        {
            Songs.printInfo(id);
            id++;
        }
    }
    public static void addSongToPLaylist(int id)
    {
        PlaylistOfSongs.Add(Library.songList[id]);
    }

    public void PlaySongPL(int id)
    {
        string songURL = PlaylistOfSongs[id].SongURL;
        string songTitle = PlaylistOfSongs[id].SongTitle;
        playListPlayer.URL = songURL;
        playListPlayer.controls.play();
        Console.Clear();
        Console.WriteLine($"Now playing: {songTitle}");
        Console.WriteLine("Press 1 to stop the music and go back to the menu.");
        var menuChoice = Console.ReadLine();
        if (menuChoice == "1")
        {
            playListPlayer.controls.stop();
        }
    }

}



