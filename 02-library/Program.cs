class Book
{
    public string Title { get; set; } // property
    public string Author { get; set; } //property
    public Book(string title, string author) // constructor w two parameters
    {
        this.Title = title;
        this.Author = author;
    } 

}
class Library
{
    public List<Book> Books { get; } = new(); // property , intitialze new List

    public void AddBook(Book b) // method addbook to list
    {
        Books.Add(b);
    }

    public Book FindBook(string title, string author)
    {
        return Books.Find(b => b.Title == title && b.Author == author);
    }
}

class Program
{
    static void Main()
    {
        Library L = new Library();
        L.AddBook(new Book("LOTR", "Tolkien"));
        L.AddBook(new Book("HarryPotter", "JK Rowling"));
        foreach (var b in L.Books)
        {
            Console.WriteLine(b.Title);
            Console.WriteLine(b.Author);
        }

        var FoundBook = L.FindBook("LOTR", "Tolkien");
        Console.WriteLine("FInd book LOTR by title: " + FoundBook.Title + " " + FoundBook.Author);
    }
}


