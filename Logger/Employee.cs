using System.Text;

namespace Logger;

//thoughts on this implementation of Employee/Student?
public record Employee : BaseEntity
{
    private FullName fullName = new("", null, "");
    protected override string GetName()
    {
        return fullName.ToString();
    }

    protected override void SetName(string name)
    {
        string[] names = name.Split();
        if (names.Length == 2)
        {
            fullName = new(names[0], names[1]);
        }
        else if (names.Length == 3)
        {
            fullName = new(names[0], names[1], names[2]);
        }
        else
        {
            throw new ArgumentException("invalid name");
        }
    }
}

