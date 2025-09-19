using System;
using Sysem.Collections.Generic;


class Book
{
    public string Title { get; set; } // property
    public Book(string title) { Title = title; }

    public string Author { get; set; } //property
    public Book(string title) { Title = title; } // constructor

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
    }
}


