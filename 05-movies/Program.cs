


class Movie
{
    public string Title { get; set; }

    public Movie(string title)
    {
        this.Title = title;
    }
}


class Collection
{
    public List<Movie> Movies { get; } = new(); // property , intializes empty at start, readable only

    public void AddMovie(Movie m)
    {
        Movies.Add(m);
    }



}