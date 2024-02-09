using Xunit;

namespace Logger.Tests;

public class IEntityRecordTests
{
    [Fact]
    public void Student_SameStudents_AreEqual()
    {
        //Arrange
        FullName name = new("test name");
        Guid guid = Guid.NewGuid();
        Student student1 = new(name, 1234567890, guid);
        Student student2 = new(name, 1234567890, guid);

        //Assert
        Assert.True(student1 == student2);
    }

    [Fact]
    public void Student_DifferentNames_NotEqual()
    {
        //Arrange
        Guid guid = Guid.NewGuid();
        Student student1 = new("Test Student1", 1234567890, guid);
        Student student2 = new("Test Student2", 1234567890, guid);

        //Assert
        Assert.False(student1 == student2);
    }

    [Fact]
    public void Student_DifferentSids_NotEqual()
    {
        //Arrange
        Guid guid = Guid.NewGuid();
        FullName name = new("test name");
        Student student1 = new(name, 111111111, guid);
        Student student2 = new(name, 222222222, guid);

        //Assert
        Assert.False(student1 == student2);
    }

    [Fact]
    public void Employee_SameEmployees_AreEqual()
    {
        //Arrange
        FullName name = new("test name");
        Guid guid = Guid.NewGuid();
        Employee employee1 = new(name, 1234567890, guid);
        Employee employee2 = new(name, 1234567890, guid);

        //Assert
        Assert.True(employee1 == employee2);
    }

    [Fact]
    public void Employee_DifferentNames_NotEqual()
    {
        //Arrange
        Guid guid = Guid.NewGuid();
        Employee employee1 = new("Test Employee1", 1234567890, guid);
        Employee employee2 = new("Test Employee2", 1234567890, guid);

        //Assert
        Assert.False(employee1 == employee2);
    }

    [Fact]
    public void Employee_DifferentEids_NotEqual()
    {
        //Arrange
        FullName name = new("test name");
        Guid guid = Guid.NewGuid();
        Employee employee1 = new(name, 111111111, guid);
        Employee employee2 = new(name, 222222222, guid);

        //Assert
        Assert.False(employee1 == employee2);
    }

    [Fact]
    public void Book_SameBooks_AreEqual()
    {
        //Arrange
        string title = "test name";
        FullName author = new("test name");
        Guid guid = Guid.NewGuid();
        Book book1 = new(title, author, 1234567890, guid);
        Book book2 = new(title, author, 1234567890, guid);

        //Assert
        Assert.True(book1 == book2);
    }

    [Fact]
    public void Book_DifferentNames_NotEqual()
    {
        //Arrange
        FullName author = new("test name");
        Guid guid = Guid.NewGuid();
        Book book1 = new("Test Employee1", author, 1234567890, guid);
        Book book2 = new("Test Employee2", author, 1234567890, guid);

        //Assert
        Assert.False(book1 == book2);
    }

    [Fact]
    public void Book_DifferentAuthors_NotEqual()
    {
        //Arrange
        string name = "test name";
        Guid guid = Guid.NewGuid();
        Book book1 = new(name, "test author1", 1234567890, guid);
        Book book2 = new(name, "test author2", 1234567890, guid);

        //Assert
        Assert.False(book1 == book2);
    }

    [Fact]
    public void Book_DifferentISBN_NotEqual()
    {
        //Arrange
        string title = "test name";
        FullName author = new("test name");
        Guid guid = Guid.NewGuid();
        Book book1 = new(title, author, 111111111, guid);
        Book book2 = new(title, author, 222222222, guid);

        //Assert
        Assert.False(book1 == book2);
    }

}
