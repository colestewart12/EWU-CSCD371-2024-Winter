using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment.Tests;

[TestClass]
public class NodeTests
{
    [TestMethod]
    public void NodeTests_ThreeItems_Success() //IDK how else to test this 
    {
        Node<string> cars = new("BMW");
        cars.Append("Volvo");
        cars.Append("Ford");

        IEnumerator<Node<string>> result = cars.GetEnumerator();

        int count = 0;

        while (result.MoveNext())
        { 
            count++; 
        }

        Assert.AreEqual(3, count);
    }

    [TestMethod]
    public void NodeTests_ReturnThreeItems_Success()
    {
        Node<string> cars = new("BMW");
        cars.Append("Volvo");
        cars.Append("Ford");
        cars.Append("Toyota");
        cars.Append("Dodge");
        cars.Append("Honda");

        List<string> expectedResult = ["BMW", "Volvo", "Ford"];

        List<Node<string>> result = cars.ChildItems(3).ToList();

        Assert.IsTrue(expectedResult.SequenceEqual<string>(result.Select(node => node.Value)));
    }


    [TestMethod]
    public void NodeTests_NodeIsNotNull_Sucess()
    {
        Node<string> myNode = new("12");

        Assert.IsNotNull(myNode.Value);
    }

    [TestMethod]
    public void NodeTests_NodeNextIsNotNull_Success()
    {
        Node<string> myNode = new("12");

        Assert.IsNotNull(myNode.Next);
    }

    [TestMethod]
    public void NodeTests_AddMultipleUniqueNodesNodeIsNotNull_Success()
    {
        Node<string> myNode = new("4");

        myNode.Append("12");
        myNode.Append("23");
        myNode.Append("18");

        Assert.IsNotNull(myNode.Value);
    }

    [TestMethod]
    public void NodeTests_AddMultipleUniqueNodesNextValueIsNotNull_Success()
    {
        Node<string> myNode = new("9");

        myNode.Append("1");
        myNode.Append("2");
        myNode.Append("8");

        Assert.IsNotNull(myNode.Next.Value);
    }

    [TestMethod]
    public void NodeTests_FirstAndSecondNodeUniqueIsNotNull_Success()
    {
        Node<string> myNode = new("4");

        myNode.Append("8");

        Assert.IsNotNull(myNode.Value);
    }

    [TestMethod]
    public void NodeTests_FirstAndSecondNodeUniqueNextIsNotNull_Success()
    {
        Node<string> myNode = new("45");

        myNode.Append("98");

        Assert.IsNotNull(myNode.Next);
    }

    [TestMethod]
    public void NodeTests_ToStringOverride_Success()
    {
        Node<int> myNode = new(12);

        Assert.AreEqual("12", myNode.ToString());
    }

    [TestMethod]
    public void NodeTests_ClearMethodDeleteNextNode_Success()
    {
        Node<string> myNode = new("12");

        myNode.Append("4");
        myNode.Clear();

        Assert.AreEqual("12", myNode.Value);
        Assert.AreNotEqual("4", myNode.Next.Value);
    }

    [TestMethod]
    public void NodeTests_ExistMethod_Success()
    {
        Node<int> myNode = new(12);

        Assert.IsTrue(myNode.Exists(12));
    }

    [TestMethod]
    public void NodeTests_NullToString_Failure()
    {
        Node<string> myNode = new(null!);

        Assert.ThrowsException<ArgumentException>(myNode.ToString);
    }

    [TestMethod]
    public void NodeTests_AppendSameValue_Failure()
    {
        Node<string> myNode = new("2");

        Assert.ThrowsException<ArgumentException>(() => myNode.Append("2"));
    }
}
