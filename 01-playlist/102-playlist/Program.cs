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
}
class Program
{
    static void Main()
    {
        var s0 = new Song("One", "Metallica");
        var s1 = new Song("Nothing Else Matters", "Metallica");
        var p = new Playlist();
        p.AddSong(s0);
        p.AddSong(s1);
        foreach (Song s in p.Songs)
            Console.WriteLine(s.Title + " " + s.Artist);
    }
}