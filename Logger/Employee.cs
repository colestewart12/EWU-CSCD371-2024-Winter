using System.Text;
using System.Xml.Linq;

namespace Logger;

//thoughts on this implementation of Employee/Student?
public record Employee : IEntity
{
    private FullName _name;

    public int Eid { get; set; }
    public Guid Id { get; init; }
    public string Name
    {
        get => _name.ToString();
        set => _name = new(value);
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

