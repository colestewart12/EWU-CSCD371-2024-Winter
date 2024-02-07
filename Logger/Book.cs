namespace Logger;

public record Book : IEntity
{

    private FullName _author;
    public int Eid { get; init; }
    Guid IEntity.Id { get => ((IEntity)this).Id; init => Guid.NewGuid(); }
    public string Author
    {
        get
        {
            return _author.ToString();
        }
        set
        {
            _author = new(value);
        }
    }

    public string Name { get; set; }
    public int Isbn { get; init; }


    public Book(string name, string author, int isbn)
    {
        Name = name;
        _author = new(author);
        Isbn = isbn;
    }
    public Book(string name, FullName author, int isbn)
    {
        Name = name;
        _author = author;
        Isbn = isbn;
    }
}

