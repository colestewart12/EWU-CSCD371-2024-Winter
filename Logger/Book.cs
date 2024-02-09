using System;

namespace Logger;

public record Book : IEntity
{
    // implemented implicitly since Name is a frequently-accessed member
    public string Name { get; set; }

    //TODO: explain why this is implemeted implicitly
    public Guid Id { get; init; }

    private FullName _author;
        public string Author
    {
        get => _author.ToString();
        set => _author = new(value);
    }
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
