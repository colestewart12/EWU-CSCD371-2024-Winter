namespace Logger;

public record Student : IEntity
{
    private FullName _name;
    public int Sid { get; init; }
    public Guid Id { get; init; }
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

