using System.Collections;

namespace Assignment;

public class Node<T> : IEnumerable<Node<T>>
{
    //Node
    public Node(T value)
    {
        Value = value;
        Next = this;
    }

    
    public T Value { get; }
    
    public Node<T> Next
    {
        get;
        private set;
    }

    public override string ToString()
    {
        if(Value is null)
        {
            throw new ArgumentException(nameof(Value));
        }

        return Value.ToString()!;
    }

    public void Append(T value)
    {
        if (Exists(value)) throw new ArgumentException("This item already exists in the list");
        Node<T> currentNode = this;
        while(currentNode.Next != this)
        {
            currentNode = currentNode.Next;
        }

        Node<T> newNode = new(value);
        currentNode.Next = newNode;
        newNode.Next = this;

    }
    public void Clear()
    {
        //With the clear method because none of the the disconnected nodes are being referenced we don't have to worry about garbage collection
        //If Clear() is never called, as long as the list isn't too big then we shouldn't worry about garbage collection
        //however if the list is too big then we need to handle garbage collection otherwise we will get a stack overflow
        Next = this;
    }
    public bool Exists(T value)
    {
        Node<T> current = this;
        do
        {
            if (current.Value!.Equals(value))
            {
                return true;
            }
        }while(current != this);

        return false;
    }

    public IEnumerator<Node<T>> GetEnumerator()
    {
        Node<T> currentNode = this;

        while(currentNode.Next != this)
        {
            yield return currentNode;
            currentNode = currentNode.Next;
        }
        if(currentNode.Next == this)
        {
            yield return currentNode;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerable<Node<T>> ChildItems(int maximum)
    {
        Node<T> currentNode = this;
        int count = 0;

        while(currentNode.Next != this && count < maximum)
        {
            yield return currentNode;
            currentNode = currentNode.Next;
            count++;
        }
    }
}

