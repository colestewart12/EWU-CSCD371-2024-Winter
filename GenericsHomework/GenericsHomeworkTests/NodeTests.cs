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

    [Fact]
    public void Clear_RemoveNext_Successful()
    {
        //Arrange
        var testNode = new Node<int>(1);
        testNode.Append(2);

        //Act
        testNode.Clear();

        //Assert
        Assert.Equal(testNode.Value, testNode.Next.Value);
    }
}