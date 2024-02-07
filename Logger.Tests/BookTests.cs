using Xunit;

namespace Logger.Tests;

public class BookTests
{
    [Fact]
    public void Book_WithFullName_SuccessfullyCreated()
    {
        // Arrange
        string name = "Test Book";
        var author = new FullName("First", "Last");
        int isbn = 1234567890;

        // Act
        var book = new Book(name, author, isbn);

        // Assert
        Assert.Equal(name, book.Name);
        Assert.Equal(author.ToString(), book.Author);
        Assert.Equal(isbn, book.Isbn);
    }
}
