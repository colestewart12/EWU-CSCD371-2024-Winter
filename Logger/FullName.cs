using System;

namespace Logger;

public record FullName
{
    public string? FirstName { get; }
    public string? MiddleName { get; }
    public string? LastName { get; }

    public FullName(string? firstName, string? middleName, string? lastName)
    {
        FirstName = firstName ?? "";
        MiddleName = middleName ?? "";
        LastName = lastName ?? "";
    }
}
