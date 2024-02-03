using System;
using Xunit;

namespace Logger.Tests;

public class FullNameTests
{
    [Fact]
    public void FullName_RecordCreated_SuccessfulCreation()
    {
        //Arrange
        var FullName = new FullName("First", "Middle", "Last");

        //Act and Assert
        Assert.Equal("First", FullName.FirstName);
        Assert.Equal("Middle", FullName.MiddleName);
        Assert.Equal("Last", FullName.LastName);

    }

    [Fact]
    public void FullName_NullValues_SuccessfulReturn()
    {
        //Arrange
        var FullName = new FullName(null, null, null);

        //Act and Assert
        Assert.Equal("", FullName.FirstName);
        Assert.Equal("", FullName.MiddleName);
        Assert.Equal("", FullName.LastName);
    }
}
