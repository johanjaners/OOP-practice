class Song
{
    public string T { get; set; }
    public string A { get; set; }
    public Song(string t, string a)
    {
        this.T = t;
        this.A = a;
    }
}
class Playlist
{
    public List<Song> Songs { get; } = new();
    public void AddSong(Song s) => Songs.Add(s);
    public void AddSong(string t, string a) => Songs.Add(new Song(t, a));
    public void RemoveSong(Song s) => Songs.Remove(s);
    public void RemoveSong(string t, string a)
    {
        var s = Songs.Find(s => s.T == t && s.A == a);
        if (s != null) Songs.Remove(s);
    }
    public Song? FindSong(string t, string a) => Songs.Find(s => s.T == t && s.A == a);
}
class Program
{
    static void Main()
    {
        var p = new Playlist();
        var s0 = new Song("One", "Metallica");
        var s1 = new Song("Fade to black", "Metallica");
        p.AddSong(s0);
        p.AddSong(s1);
        Console.WriteLine("Count is 2: " + (p.Songs.Count == 2));
        var found = p.FindSong("One", "Metallica");
        Console.WriteLine("Found One: " + (found != null && found.T == "One"));
        p.RemoveSong(s0);
        Console.WriteLine("Count is 1 after One removed: " + (p.Songs.Count == 1));
        p.RemoveSong("Fade to black", "Metallica");
        Console.WriteLine("Count is 0 after second remove: " + (p.Songs.Count == 0));
    }
}