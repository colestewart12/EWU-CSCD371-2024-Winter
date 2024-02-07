﻿using System;

namespace Logger;

public record Book : IEntity
{
    private FullName _author;

    public Guid Id { get; init; } // Implementing Id property from IEntity interface

    public string Author
    {
        get => _author.ToString();
        set => _author = new(value);
    }

    public string Name { get; set; }
    public int Isbn { get; init; }

    public Book(string name, string author, int isbn)
    {
        Id = Guid.NewGuid(); // Generating Id when constructing a new Book
        Name = name;
        _author = new(author);
        Isbn = isbn;
    }

    public Book(string name, FullName author, int isbn)
    {
        Id = Guid.NewGuid(); // Generating Id when constructing a new Book
        Name = name;
        _author = author;
        Isbn = isbn;
    }
}
