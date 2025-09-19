using System;
using Sysem.Collections.Generic;


class Book
{
    public string Title { get; set; } // property
    public string Author { get; set; } //property
    public Book(string title, string author) // constructor w two parameters
    {
        Title = title;
        Author = Author;
    } 

}


class Library
{
    public List<Book> Books { get; } = new(); // property, intitialze new, read only outside

    public void AddBook(Book b)
    {
        Books.Add(b);
    }

}


class Program
{
    static void Main()
    {
        Library L = new Library();
        L.AddBook(new Book("LOTR", "Tolkien"));
    }
}


