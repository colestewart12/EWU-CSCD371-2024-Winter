using System.Diagnostics.Metrics;
using Xunit;

namespace GenericsHomework.Tests;

public class NodeTests
{
    [Fact]
    public void Append_AddNewNode_Successful()
    {
        //Arrange
        Node<string> testNode = new("First");

        //Act
        testNode.Append("Second");

        //Assert
        Assert.Equal("Second", testNode.Next.Value);

    }

    [Fact]
    public void Append_DuplicateValue_ThrowsError()
    {
        //Arrange
        Node<string> testNode = new("Node 1");

        //Assert
        Assert.Throws<InvalidOperationException>(() => testNode.Append("Node 1"));
    }

    [Fact]
    public void Clear_RemoveNext_Successful()
    {
        //Arrange
        Node<int> testNode = new(1);
        testNode.Append(2);

        //Act
        testNode.Clear();

        //Assert
        Assert.Equal(testNode.Value, testNode.Next.Value);
    }

    [Fact]
    public void Exists_RegularNode_Successful()
    {
        //Arrange
        Node<int> testNode = new(1);

        //Act and Assert
        Assert.True(testNode.Exists(1));
    }

    [Fact]
    public void ToString_ValidNode_Successful()
    {
        //Arrange
        Node<int> testNode = new(1);

        //Act and Assert
        Assert.Equal("1", testNode.ToString());

    }

    [Fact]
    public void ToString_NullNode_ThrowException()
    {
        //Arrange
        Node<string> testNode = new(null!);

        //Act
        Assert.Throws<InvalidOperationException>(() => testNode.ToString());
    }

    [Fact]
    public void Exists_MissingNode_Unsuccessful()
    {
        //Arrange
        Node<string> testNode = new("First");

        //Act
        testNode.Append("Second");

        //Assert
        Assert.False(testNode.Exists("Third"));

    }
}