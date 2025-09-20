class Movie
{
    public string Title { get; set; }
    public int Year { get; set; }
    public Movie(string title, int year)
    {
        this.Title = title;
        this.Year = year;
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
class Program
{
    static void Main()
    {
        Collection C = new Collection();

        C.AddMovie(new Movie("Xmen", 2010));
        C.AddMovie(new Movie("Thor", 2012));

        Console.WriteLine(C.Movies[0].Title);

        Console.WriteLine(C.Movies[1].Year);
    }
}