using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList.DoublyLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable
    {
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }

        private bool isHeadNull => Head == null; 
        private bool isTailNull => Tail == null; 

        public DoublyLinkedList()
        {

        }
        public DoublyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                AddLast(item);
            }
        }

        public void Addfirst(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);
            if(Head != null)
            {
                Head.Prev = newNode;
            }
            newNode.Next = Head;
            newNode.Prev = null;
            Head = newNode;

            if(Tail == null)
            {
                Tail = Head;
            }
        }
        public void AddLast(T value)
        {
            if(Tail == null)
            {
                Addfirst(value);
                return;
            }
             
            var newNode = new DoublyLinkedListNode<T>(value);
            Tail.Next = newNode;
            newNode.Next = null;
            newNode.Prev = Tail;
            Tail = newNode;
        }
        public void AddAfter(DoublyLinkedListNode<T> refNode, DoublyLinkedListNode<T> newNode)
        {
            if(refNode == null)
            {
                throw new ArgumentNullException();
            }

            if (refNode == Head && refNode == Tail)
            {
                refNode.Next = newNode;
                refNode.Prev = null;

                newNode.Prev = refNode;
                newNode.Next = null;

                Head = refNode;
                Tail = newNode;
                return;
            }

            if(refNode != Tail)
            {
                newNode.Prev = refNode;
                newNode.Next = refNode.Next;

                refNode.Next.Prev = newNode;
                refNode.Next = newNode;
            }
            else
            {
                newNode.Prev = refNode;
                newNode.Next = null;
                refNode.Next = newNode;
                Tail = newNode;
            }
        }
        public void AddBefore(DoublyLinkedListNode<T> refNode, DoublyLinkedListNode<T> newNode)
        {
            if(refNode == null)
            {
                throw new ArgumentNullException();
            }

            if(refNode == Head && refNode == Tail)
            {
                newNode.Prev = null;
                newNode.Next = refNode;

                refNode.Prev = newNode;
                refNode.Next = null;

                Head = newNode;
                Tail = refNode;
                return;
            }

            if (refNode == Head)
            {
                newNode.Next = refNode;
                newNode.Prev = null;

                refNode.Prev = newNode;

                Head = newNode;
            }
            else
            {
                newNode.Prev = refNode.Prev;
                newNode.Next = refNode;
                
                refNode.Prev.Next = newNode;
                refNode.Prev = newNode;
                
            }

        }

        private System.Collections.Generic.List<DoublyLinkedListNode<T>> GetAllNodes()
        {
            var list = new System.Collections.Generic.List<DoublyLinkedListNode<T>>();

            var current = Head;

            while(current != null)
            {
                list.Add(current);
                current = current.Next;
            }

            return list;
        }

        public IEnumerator GetEnumerator()
        {
            return GetAllNodes().GetEnumerator();
        }

        public T RemoveFirst()
        {
            if (isHeadNull)
            {
                throw new ArgumentNullException();
            }

            var temp = Head.Value;

            if(Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Next;
                Head.Prev = null;
            }

            return temp;
        }
        public T RemoveLast()
        {
            if (isTailNull)
            {
                throw new ArgumentException("List is empty.");
            }

            var temp = Tail.Value;

            if(Tail == Head)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail.Prev.Next = null;
                Tail = Tail.Prev;
            }
            return temp;
        }

        public void Remove(T value)
        {
            if (isHeadNull)
            {
                throw new ArgumentException("Empty list.");
            }

            //Tek eleman
            if(Head == Tail)
            {
                if (Head.Value.Equals(value))
                {
                    RemoveFirst();
                }
            } 

            // en az iki eleman
            var current = Head;

            while(current != null)
            {
                if (current.Value.Equals(value))
                {   // ilk eleman
                    if (current.Prev == null)
                    {
                        current.Next.Prev = null;
                        Head = current.Next;
                    }
                    // son elaman
                    else if(current.Next == null)
                    {
                        current.Prev.Next = null;
                        Tail = current.Prev;
                    }
                    // arada eleman
                    else
                    {
                        current.Prev.Next = current.Next;
                        current.Next.Prev = current.Prev;
                        current = null;
                    }
                    break;
                }
                current = current.Next;
            }
        }
    }
}
