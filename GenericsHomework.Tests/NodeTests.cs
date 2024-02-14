using GenericsHomework;
using System;
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
        var testNode = new Node<string>("Node 1");

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
}