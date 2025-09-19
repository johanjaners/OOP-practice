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
    public List<Book> Books { get; } = new(); // property , intitialze new List, read only outside

    public void AddBook(Book b) // method addbook to list
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
        L.AddBook(new Book("HarryPotter", "JK Rowling"));
        foreach (var b in Books)
        {
            Console.WriteLine(Books(b.Title));
            Console.WriteLine(Books(b.Author));
        }
    }
}


