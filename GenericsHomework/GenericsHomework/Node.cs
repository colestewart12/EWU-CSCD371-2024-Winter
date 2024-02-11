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

        public override string ToString()
        {
            return Value.ToString();
        }


        public void Append(T value)
        {
            if (Exists(value))
            {
                throw new InvalidOperationException("Error: No duplicate values allowed");
            }

            Node<T> newNode = new Node<T>(value);
            newNode.Next = Next;
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
                if (current.Value.Equals(value)) return true;
                current = current.Next;

            } while (current != this);
            return false;
        }



    }
}
