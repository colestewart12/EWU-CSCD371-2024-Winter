using GenericsHomework;

namespace GenericsHomeworkTests;

public class NodeTests
{
    [Fact]
    public void Append_AddNewNode_Successful()
    {
        //Arrange
        var testNode = new Node<string>("First");

        //Act
        testNode.Append("Second");

        //Assert
        Assert.Equal("Second", testNode.Next.Value);

    }
}