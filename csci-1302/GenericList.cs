using System;
using System.Collections.Generic;

namespace csci_1302
{
    // type parameter T in angle brackets
    public class GenericList<T>
    {
       #region HideThis
        // The nested class is also generic on T.
        private class Node
        {
            // T used in non-generic constructor.
            public Node(T t)
            {
                next = null;
                data = t;
            }

            private Node next;
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }

            // T as private member data type.
            private T data;

            // T as return type of property.
            public T Data
            {
                get { return data; }
                set { data = value; }
            }
        }

        private Node head;

        public bool IsEmpty
        {
            get { return head == null;  }
        }

        public int Count
        {
            get
            {
                int _count = 0;

                Node current = head;
                while (current != null)
                {
                    _count++; 
                    current = current.Next;
                }
                return _count;
            }
        }

        public T Search(T lookfor)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data.Equals(lookfor))
                    return current.Data;

                current = current.Next;
            }
            return default(T);
        }

        // constructor
        public GenericList()
        {
            Clear();
        }

        public void Clear()
        {
            head = null;
        }

        // T as method parameter type:
        public void AddHead(T t)
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
        }

        public void AddTail(T t)
        {
            if (IsEmpty)
                AddHead(t);
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                Node n = new Node(t);
                current.Next = n;
            }
        }

        public void RemoveHead()
        {
            if (!IsEmpty)
                head = head.Next;
        }

        // this method allows us to use foreach
        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        #endregion
    }
}