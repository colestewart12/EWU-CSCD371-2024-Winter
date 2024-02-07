using System.Text;
using System.Xml.Linq;

namespace Logger;

//thoughts on this implementation of Employee/Student?
public record Employee : IEntity
{
    private FullName _name;
    public int Eid { get; init; }
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

    public Employee(FullName name, int eid)
    {
        _name = name; 
        Eid = eid;
    }
    public Employee(string name, int eid)
    {
        _name = new(name);
        Eid = eid;
    }
}

