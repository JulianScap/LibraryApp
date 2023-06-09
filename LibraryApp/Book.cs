﻿namespace LibraryApp;

public class Book
{
    public string Title { get; set; }

    public Book(string title)
    {
        Title = title;
    }

    public override string ToString()
    {
        return $"Book {Title}";
    }
}