class Song
{
    public string T { get; set; }
    public string A { get; set; }
    public Song (string t, string a)
    {
        this.T = t;
        this.A = a;
    }
}
class P
{
    public List<Song> Songs { get; } = new();
    public void AddS(Song s) => Songs.Add(s);
    public void RemoveS(Song s) => Songs.Remove(s);
    public Song? FindSong(string t, string a) => Songs.Find(s => s.T == t && s.A == a);
}
class Program
{
    static void Main()
    {
        var p = new P();
        var s0 = new Song("one", "metallica");
        var s1 = new Song("fade to black", "metallica");
        p.AddS(s0);
        p.AddS(s1);
        Console.WriteLine("Count is 2: " + (p.Songs.Count == 2));
        var found = p.FindSong("one", "metallica");
        Console.WriteLine("Found One: " + (found != null && found.T == "one"));

        p.RemoveS(s0);
        Console.WriteLine("Count is 1 after remove: " + (p.Songs.Count == 1));
    }
}