using Xunit;

namespace Logger.Tests;

public class StorageTests
{
    private sealed class TestEntity : IEntity
    {
        public Guid Id { get; init; }
        public required string Name { get; set; }
    }

    [Fact]
    public void AddandContains_BaseEntity_SuccessfullyAdded()
    {
        //Arrange
        var storage = new Storage();
        var baseEntity = new TestEntity { Id = Guid.NewGuid(), Name = "New Entity" };

        //Act
        storage.Add(baseEntity);

        //Assert
        Assert.True(storage.Contains(baseEntity));
    }

    [Fact]
    public void Remove_BaseEntity_SuccessfullyRemoved()
    {
        //Arrange
        var storage = new Storage();
        var baseEntity = new TestEntity { Id = new Guid(), Name = "New Entity" };

        storage.Add(baseEntity);

        //Act
        storage.Remove(baseEntity);

        //Assert
        Assert.False(storage.Contains(baseEntity));
    }

    [Fact]
    public void Get_BaseEntity_SuccessfulFind()
    {
        //Arrange
        var storage = new Storage();
        var testId = Guid.NewGuid();
        var testEntity = new TestEntity { Id = testId, Name = "New Entity" };
        storage.Add(testEntity);

        //Act
        var returned = storage.Get(testId);

        //Assert
        Assert.Equal(testEntity, returned);
    }

    [Fact]
    public void Get_BaseEntity_NotFound()
    {
        //Arrange
        var storage = new Storage();
        var testId = Guid.NewGuid();

        //Act
        var returned = storage.Get(testId);

        //Assert
        Assert.Null(returned);
    }

    [Fact]
    public void AddandContains_BookEntity_SuccessfullyAdded()
    {
        //Arrange
        var storage = new Storage();
        var book = new Book("Book Name", "Author Name", 1234567890);

        //Act
        storage.Add(book);

        //Assert
        Assert.True(storage.Contains(book));
    }

    [Fact]
    public void Remove_BookEntity_SuccessfullyAdded()
    {
        //Arrange
        var storage = new Storage();
        var book = new Book("Book Name", "Author Name", 1234567890);
        storage.Add(book);

        //Act
        storage.Remove(book);

        //Assert
        Assert.True(!storage.Contains(book));
    }

    [Fact]
    public void Get_BookEntity_SuccessfulFind()
    {
        // Arrange
        var storage = new Storage();
        var book = new Book("Book Name", "Author Name", 1234567890);
        storage.Add(book);

        // Act
        var returned = storage.Get(book.Id);

        // Assert
        Assert.Equal(book, returned);
    }

    [Fact]
    public void AddandContains_EmployeeEntity_SuccessfullyAdded()
    {
        //Arrange
        var storage = new Storage();
        var employee = new Employee("Test Employee", 1234567890);

        //Act
        storage.Add(employee);

        //Assert
        Assert.True(storage.Contains(employee));
    }

    [Fact]
    public void Remove_EmployeeEntity_SuccessfullyRemoved()
    {
        //Arrange
        var storage = new Storage();
        var first = "First";
        var last = "Last";
        var name = new FullName(first, last);
        var employee = new Employee(name, 1234567890);
        storage.Add(employee);

        //Act
        storage.Remove(employee);

        //Assert
        Assert.True(!storage.Contains(employee));
    }

    [Fact]
    public void Get_EmployeeEntity_SuccessfulFind()
    {
        //Arrange
        var storage = new Storage();
        var employee = new Employee("Test Employee", 1234567890);
        storage.Add(employee);

        // Act
        var returned = storage.Get(employee.Id);

        // Assert
        Assert.Equal(employee, returned);
    }
}
