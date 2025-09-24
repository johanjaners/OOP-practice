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
