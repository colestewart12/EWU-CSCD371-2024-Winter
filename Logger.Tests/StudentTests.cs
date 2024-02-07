using Xunit;

namespace Logger.Tests;

public class StudentTests
{
    [Fact]
    public void Student_GetStudentId_SuccessfulGet()
    {
        //Arrange
        var student = new Student("Test Student", 1234567890);

        //Assert
        Assert.Equal(1234567890, student.Sid);
    }

    [Fact]
    public void Student_GetName_SuccessfulGet()
    {
        //Arrange
        var student = new Student("Test Student", 1234567890);

        //Assert
        Assert.Equal("Test Student", student.Name);
    }
}
