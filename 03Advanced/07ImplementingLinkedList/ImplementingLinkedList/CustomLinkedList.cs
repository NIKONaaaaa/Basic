namespace ImplementingLinkedList
{
    using System.Collections;
    using System.Collections.Generic;
    public class CustomLinkedList<T> : IEnumerable<T>
    {
        public class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }

            public Node(T value)
            {
                Value = value;
            }
        }
        public Node<T> Head { get; set; }
        public int Count { get; private set; }

        public void Add(Node<T> node)
        {
            if (Head == null)
            {
                this.Head = node;
            }
            else
            {
                node.Next = Head;
                this.Head = node;
            }
            this.Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = this.Head;
            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}