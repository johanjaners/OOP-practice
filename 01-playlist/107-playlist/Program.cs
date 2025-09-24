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
    public void AddS(Song s) => Songs.Add(s);
    public void RemoveS(Song s) => Songs.Remove(s);
    public Song? FindS(string t, string a) => Songs.Find(s => s.T == t && s.A == a);
}
class Program
{
    static void Main()
    {
        var p = new Playlist();
        var s0 = new Song("One", "Metallica");
        var s1 = new Song("Fade to black", "Metallica");
        p.AddS(s0);
        p.AddS(s1);
        Console.WriteLine("Count is 2 after two add: " + (p.Songs.Count == 2));
        var found = p.FindS("One", "Metallica");
        Console.WriteLine("Found One: " + (found != null && found.T == "One"));

    }
}