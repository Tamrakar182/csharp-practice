using System.Text;

namespace DecoratorsGenerics
{
    public class LinkedList<T>
    {
        private Node<T>? _head;

        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = _head;
            _head = newNode;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("[");
            Node<T>? current = _head;
            while (current != null)
            {
                sb.Append(current.Data);
                sb.Append(", ");
                current = current.Next;
            }
            sb.Append("]");
            return sb.ToString().TrimEnd(',', ' ');
        }

        private class Node<U>
        {
            public U Data { get; set; }
            public Node<U>? Next { get; set; }

            public Node(U data)
            {
                Data = data;
            }
        }
    }

}