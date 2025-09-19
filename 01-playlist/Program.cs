using System;
using System.Collections.Generic;

class Song
{
    public string Title { get; set; } // property
    public Song(string title) // constructor
    {
        Title = title;
    }
}
class Playlist
{
    public List<Song> Songs { get; } = new(); // property, initialize new list
    public void AddSong(Song s) => Songs.Add(s); // method 
}

class Program
{
    static void Main()
    {
        Song s = new Song("Nothing Else Matters"); // create object
        Console.WriteLine(s.Title); // use property

        Playlist p = new Playlist();
        p.AddSong(s);
        p.AddSong(new Song("Fade to Black"));
        foreach (var song in p.Songs)
        {
            Console.WriteLine(song.Title);
        }


    }
}