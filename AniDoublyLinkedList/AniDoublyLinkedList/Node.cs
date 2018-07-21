using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniDoublyLinkedList
{
    public class Node<T>
    {
        public Node<T> Next{ get; set; }
        public Node<T> Previous{ get; set; }
        public T Value;
        public Node(T ItemToAdd, Node<T> next = null, Node<T> previous = null)
        {
            Value = ItemToAdd;
            Next = next;
            Previous = previous;
        }
    }
}
