namespace GenericsHomework;
public class Node<T>
{
    //Type T so that values are homogenous
    public T Value { get; }
    public Node<T> Next { get; private set; }

    public Node(T value)
    {
        Value = value;

        // Points at itself initially
        Next = this;
    }

    public override string ToString()
    {
        return Value?.ToString() ?? throw new InvalidOperationException($"{nameof(Value)} is null.");
    }


    public void Append(T value)
    {
        if (Exists(value))
        {
            throw new InvalidOperationException("Error: No duplicate values allowed");
        }

        Node<T> newNode = new(value)
        {
            Next = Next
        };
        Next = newNode;
    }

    public void Clear()
    {
        //Since the list is singly linked, they will be available for garbage collection
        Next = this;
    }

    public bool Exists(T value)
    {
        Node<T> current = this;

        do
        {
            bool isFound = current.Value?.Equals(value) ?? throw new InvalidOperationException(nameof(Value));
            if (isFound) 
                return true;
            current = current.Next;

        } while (current != this);
        return false;
    }
 }