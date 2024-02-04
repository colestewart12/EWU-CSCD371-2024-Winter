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
        Assert.Equal("First Middle Last", FullName.ToString());
        Assert.Equal("First", FullName.FirstName);
        Assert.Equal("Middle", FullName.MiddleName);
        Assert.Equal("Last", FullName.LastName);

    }

    [Fact]
    public void FullName_TwoArguments_SuccessfulReturn()
    {
        //Arrange
        var FullName = new FullName("First", "Last");

        //Act and Assert
        Assert.Equal("First Last", FullName.ToString());
    }

    [Fact]
    public void FullName_NullValue_SuccessfulReturn()
    {
        //Arrange
        var FullName = new FullName("First", null, "Last");

        //Act and Assert
        Assert.Equal("First Last", FullName.ToString());
    }
}
