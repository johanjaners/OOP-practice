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
    public void AddSong(string title, string artist) => Songs.Add(new Song(title, artist));
    public void RemoveSong(Song s) => Songs.Remove(s);
    public void RemoveSong(string title, string artist)
    {
        var songToRemove = Songs.find(r => r.Title == title && r.Artist == artist);
        if (songToRemove != null) Songs.Remove(songToRemove);
    }
    public Song? FindSong(string title, string artist) => Songs.Find(x => x.Title == title && x.Artist == artist);
}
class Program
{
    static void Main()
    {

    }
}