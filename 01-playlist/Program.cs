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

class Program
{
    static void Main()
    {
        Song s = new Song("Nothing Else Matters"); // create object
        Console.WriteLine(s.Title); // use property
    }
}