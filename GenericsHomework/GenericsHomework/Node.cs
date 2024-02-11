using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework
{
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

        public void Append(T value)
        {

            Node<T> newNode = new Node<T>(value);
            newNode.Next = Next;
            Next = newNode;
        }

    }
}
