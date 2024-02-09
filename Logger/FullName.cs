using System.Text;

namespace Logger;

// value type, since it is more helpful to check equality of a name's data (the actual name) than its reference (the location in memory)
// not immutable, as someone's name can change
public record class FullName
{
    public string FirstName { get; init; }
    public string? MiddleName { get; init; }
    public string LastName { get; init; }

    public FullName(string firstName, string? middleName, string lastName)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
    }
    public FullName(string firstName, string lastName) : this(firstName, null, lastName){}
    public FullName(string fullName)
    {
        string[] names = fullName.Split();
        if (names.Length == 2)
        {
            FirstName = names[0];
            MiddleName = null;
            LastName = names[1];
        }
        else if (names.Length == 3)
        {
            FirstName = names[0];
            MiddleName = names[1];
            LastName = names[2];
        }
        else if (FirstName == null || LastName == null)
        {
            throw new ArgumentException("first name and last name can't be null");
        }
        else
        {
            throw new ArgumentException("invalid name");
        }
    }

    public override string ToString()
    {
        StringBuilder result = new();
        result.Append(FirstName);
        if (MiddleName is not null)
        {
            result.Append(" " + MiddleName);
        }
        result.Append(" " + LastName);
        return result.ToString();
    }
}
