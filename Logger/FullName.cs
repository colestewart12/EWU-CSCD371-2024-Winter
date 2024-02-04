using System.Text;

namespace Logger;

public record FullName
{
    public string FirstName { get; }
    public string? MiddleName { get; }
    public string LastName { get; }

    public FullName(string firstName, string? middleName, string lastName)
    {
        FirstName = firstName;
        MiddleName = middleName ?? "";
        LastName = lastName;
    }
    public FullName(string firstName, string lastName)
    {
        FirstName = firstName;
        MiddleName = null;
        LastName = lastName;
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
