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
    public void RemoveSong(Song s) => Songs.Remove(s);
    public Song? FindSong(string title, string artist) => Songs.Find(s => s.Title == title && s.Artist == artist);
}