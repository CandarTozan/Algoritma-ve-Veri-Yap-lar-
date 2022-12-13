using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList.SinglyLinkedList
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        public SinglyLinkedListNode<T> Head { get; set; }

        private bool isHeadNull => Head == null;

        public SinglyLinkedList()
        {

        }

        public SinglyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                this.AddLast(item);
            }
        }

        public void AddFirst(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddLast(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);

            if(isHeadNull)
            {
                Head = newNode;
                return;
            }

            var current = Head;
            while(current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void AddAfter(SinglyLinkedListNode<T> node, T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);

            if(node == null)
            {
                throw new ArgumentException("The referance node is null.");
            }
            if (isHeadNull)
            {
                AddFirst(value);
                return;
            }
            var current = Head;

            while(current != null)
            {
                if (current.Equals(node))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }

            throw new ArgumentException("The referance node is not in this list.");
        }

        public void AddAfter(SinglyLinkedListNode<T> refNode, SinglyLinkedListNode<T> newNode)
        {
            if (refNode == null)
            {
                throw new ArgumentException("The referance node is null.");
            }
            if (isHeadNull)
            {
                newNode.Next = Head;
                Head = newNode;
                return;
            }

            var current = Head;
            while (current != null)
            {
                if (current.Equals(refNode))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }

            throw new ArgumentException("The referance node is not int the list.");
        }

        public void AddBefore(SinglyLinkedListNode<T> node, T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);

            if(node == null)
            {
                throw new ArgumentException("The referance node is null.");
            }
            if (Head.Next == null)
            {
                AddFirst(value);
            }

            var current = Head;
            while(current != null)
            {
                if (current.Next.Equals(node))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T RemoveFirst()
        {
            if (isHeadNull)
            {
                throw new ArgumentException("Nothing to remove.");
            }
            var firstValue = Head.Value;
            Head = Head.Next;
            return firstValue;
        }

        public T RemoveLast()
        {
            var current = Head;
            SinglyLinkedListNode<T> prev = null;
            while(current.Next != null)
            {
                prev = current;
                current = current.Next;
            }
            var lastValue = prev.Next.Value;
            prev.Next = null;
            return lastValue;
        }

        public void Remove(T value)
        {
            if (isHeadNull)
            {
                throw new ArgumentException("Nothing to remove");
            }
            if(value == null)
            {
                throw new ArgumentNullException();
            }

            var current = Head;
            SinglyLinkedListNode<T> prev = null;

            do
            {
                if (current.Value.Equals(value))
                {
                    // Son elaman mı?
                    if(current.Next == null)
                    {
                        // Head mi?
                        if(prev == null)
                        {
                            Head = null;
                            return;
                        }
                        // Son eleman
                        else
                        {
                            prev.Next = null;
                            return;
                        }
                    }
                    else
                    {
                        //head
                        if(prev == null)
                        {
                            Head = Head.Next;
                            return;
                        }
                        // Ara node
                        else
                        {
                            prev.Next = current.Next;
                            return;
                        }
                    }
                }
                prev = current;
                current = current.Next;
            } while (current != null);

            throw new ArgumentException("The value could not be found in the list.");
        }
    }
}
