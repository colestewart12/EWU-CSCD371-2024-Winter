
namespace Logger;

public record Employee : IEntity
{
    private FullName _name;
    public int Eid { get; set; }

    //TODO: explain why this is implemeted implicitly
    public Guid Id { get; init; }

    // implemented implicitly since Name is a frequently-accessed
    public string Name
    {
        get => _name.ToString();
        set => _name = new(value);
    }

    public Employee(FullName name, int eid, Guid id)
    {
        _name = name;
        Id = id;
        Eid = eid;
    }
    public Employee(string name, int eid, Guid id)
    {
        _name = new(name);
        Id = id;
        Eid = eid;
    }
    public Employee(FullName name, int eid)
    {
        _name = name;
        Id = Guid.NewGuid();
        Eid = eid;
    }
    public Employee(string name, int eid)
    {
        _name = new(name);
        Id = Guid.NewGuid();
        Eid = eid;
    }
}

