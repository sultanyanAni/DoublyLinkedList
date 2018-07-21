using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniDoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        Node<T> Head;
        Node<T> Tail;
        int Count = 0;

        public DoublyLinkedList()
        {

        }
  

        public IEnumerator<Node<T>> GetEnumerator()
        {
            Node<T> currentNode = Head;
            while (currentNode != null)
            {
                yield return currentNode;
                currentNode = currentNode.Next;
            }
        }

        bool IsEmpty()
        {
            return Head == null;
        }
        public void AddToEnd(T itemToAdd)
        {
            Node<T> currentNode = Tail;
            if (IsEmpty())
            {
                Head = new Node<T>(itemToAdd);
                Tail = Head;
            }
            else
            {

                Tail.Next = new Node<T>(itemToAdd, null, Tail);
                Tail = Tail.Next;
            }
            Count++;
        }
        public void AddToFront(T itemToAdd)
        {
            Node<T> nodeToInsert = new Node<T>(itemToAdd);
            if (IsEmpty())
            {
                Head = nodeToInsert;
                Tail = Head;

            }
            else
            {
                nodeToInsert.Next = Head;
                Head = nodeToInsert;


            }
            Count++;
        }
        public void AddBefore(T itemToAdd, int indexToAddBefore)
        {
            if (IsEmpty())
            {
                AddToFront(itemToAdd);
            }
            else
            {
                Node<T> CurrentNode = Head;
                int count = 0;
                while (count < indexToAddBefore)
                {
                    CurrentNode = CurrentNode.Next;
                    count++;
                }

                Node<T> nodeToAdd = new Node<T>(itemToAdd);
                CurrentNode.Previous.Next = nodeToAdd;
                nodeToAdd.Previous = CurrentNode.Previous;
                CurrentNode.Previous = nodeToAdd;
                nodeToAdd.Next = CurrentNode;
              

            }
            Count++;
        }
        public void AddAfter(T itemToAdd, int indexToAddAfter)
        {
            if (IsEmpty())
            {
                AddToFront(itemToAdd);
            }
            else
            {
                Node<T> CurrentNode = Head;
                int count = 0;
                while (count < indexToAddAfter)
                {
                    CurrentNode = CurrentNode.Next;
                    count++;
                }
                if (CurrentNode.Next == null)
                {
                    AddToEnd(itemToAdd);
                }
                else
                {
                    Node<T> nodeToAdd = new Node<T>(itemToAdd);
                    nodeToAdd.Next = CurrentNode.Next;
                    CurrentNode.Next.Previous = nodeToAdd;
                    CurrentNode.Next = nodeToAdd;
                    nodeToAdd.Previous = CurrentNode;
                }
            }
            Count++;
        }

        public bool RemoveFromFront()
        {
            if(IsEmpty())
            {
                return false;
            }
            else if(Head.Next == null)
            {
                Head = null;
                Count--;
                return true;
            }
            else
            {
                Head = Head.Next;
                Head.Next.Previous = null;
                Count--;
                return true;
            }

        }

        public bool RemoveFromEnd()
        {
            if(IsEmpty())
            {
                return false;
            }
            else
            {
                Tail = Tail.Previous;
                Tail.Next = null;
                return true;
            }
        }
    
        public bool RemoveAt(int indexToRemoveAt)
        {
            if(IsEmpty())
            {
                return false;
            }
            else if(indexToRemoveAt == 0)
            {
                RemoveFromFront();
                Count--;
                return true;
            }
            else
            {
                Node<T> currentNode = Head;
                int count = 0;
                while(count < indexToRemoveAt)
                {
                    currentNode = currentNode.Next;
                    count++;
                }
                if(currentNode == null)
                {
                    return false;
                }
                else if(currentNode.Next == null)
                {
                    RemoveFromEnd();
                    Count--;
                    return true;
                }
                else
                {
                    currentNode.Previous.Next = currentNode.Next;
                    currentNode.Next.Previous = currentNode.Previous;
                    Count--;
                    return true;
                }

            }
        }

       
    }
}
