class Song
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public Song(string title, string artist)
    {
        this.Title = title;
        this.Artist = artist;
    }
}
class Playlist
{
    public List<Song> Songs { get; } = new();
    public void AddSong(Song s) => Songs.Add(s);
    //public void AddSong(string title, string artist) => Songs.Add(new Song(title, artist));
    public void RemoveSong(Song s) => Songs.Remove(s);
    // public void RemoveSong(string title, string artist)
    // {
    //     var songToRemove = Songs.Find(r => r.Title == title && r.Artist == artist);
    //     if (songToRemove != null) Songs.Remove(songToRemove);
    // }
    public Song? FindSong(string title, string artist) => Songs.Find(x => x.Title == title && x.Artist == artist);
}
class Program
{
    static void Main()
    {
        var p = new Playlist();
        var s0 = new Song("One", "Metallica");
        var s1 = new Song("Fade to Black", "Metallica");
        p.AddSong(s0);
        p.AddSong(s1);
        Console.WriteLine("count 2: " + (p.Songs.Count == 2));

        var found = p.FindSong("One", "Metallica");
        Console.WriteLine("Found One: " + (found != null && found.Title == "One"));

        p.RemoveSong(s0);
        Console.WriteLine("count 1 after remove: " + (p.Songs.Count == 1));
    }
}