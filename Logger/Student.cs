namespace Logger;

public record Student : IEntity
{
    private FullName _name;
    public int Sid { get; init; }
    Guid IEntity.Id { get => ((IEntity)this).Id; init => Guid.NewGuid(); }
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
    }
    public Student(string name, int sid)
    {
        _name = new(name);
        Sid = sid;
    }
}

