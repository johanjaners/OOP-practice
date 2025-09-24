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
        Songs.Find(s => s.T == t && s.A == a);
        if (s != null) Songs.Remove(s);
    }
    public Song? FindSong(string t, string a) => Songs.Find(s => s.T == t && s.A == a);
}