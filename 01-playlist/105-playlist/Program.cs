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