namespace Logger;

public record Student : IEntity
{
    private FullName _name;
    public int Sid { get; init; }

    //TODO: explain why this is implemeted implicitly
    public Guid Id { get; init; }

    // implemented implicitly since Name is a frequently-accessed
    public string Name
    {
        get
        {
            return _name.ToString();
        }
        set
        {
            _name = new(value);
        }
    }
    public Student(FullName name, int sid, Guid id)
    {
        _name = name;
        Sid = sid;
        Id = id;
    }
    public Student(string name, int sid, Guid id)
    {
        _name = new(name);
        Sid = sid;
        Id = id;
    }

    public Student(FullName name, int sid)
    {
        _name = name;
        Sid = sid;
        Id = Guid.NewGuid();
    }
    public Student(string name, int sid)
    {
        _name = new(name);
        Sid = sid;
        Id = Guid.NewGuid();
    }
}

