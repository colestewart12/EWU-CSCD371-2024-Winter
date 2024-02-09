using System;

namespace Logger;

public record Book : IEntity
{
    private FullName _author;

    public Guid Id { get; init; }

    public string Author
    {
        get => _author.ToString();
        set => _author = new(value);
    }

    public string Name { get; set; }
    public int Isbn { get; init; }

    public Book(string name, string author, int isbn, Guid id)
    {
        Id = id;
        Name = name;
        _author = new(author);
        Isbn = isbn;
    }

    public Book(string name, FullName author, int isbn, Guid id)
    {
        Id = id;
        Name = name;
        _author = author;
        Isbn = isbn;
    }

    public Book(string name, string author, int isbn)
    {
        Id = Guid.NewGuid();
        Name = name;
        _author = new(author);
        Isbn = isbn;
    }

    public Book(string name, FullName author, int isbn)
    {
        Id = Guid.NewGuid();
        Name = name;
        _author = author;
        Isbn = isbn;
    }
}
