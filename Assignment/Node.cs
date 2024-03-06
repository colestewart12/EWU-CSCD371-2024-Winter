using System.Collections;

namespace Assignment;

public class Node<T> : IEnumerable<T>
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
        Node<T> newNode = new(value)
        {
            Next = Next
        };
        Next = newNode;
        //return newNode;

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

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

