﻿using DataStructures.LinkedList.SinglyLinkedList;
using System;

namespace DataStructures.Stack
{
    public class LinkedListStack<T> : IStack<T>
    {
        private readonly SinglyLinkedList<T> list = new SinglyLinkedList<T>();
        public int Count { get; private set; }

        public T Peek()
        {
            if (Count == null)
            {
                throw new Exception("Empty stack.");
            }

            return list.Head.Value;
        }

        public T Pop()
        {
            if(Count == null)
            {
                throw new Exception("Empty stack.");
            }
            Count--;
            var temp = list.RemoveFirst();
            return temp;
        }

        public void Push(T value)
        {
            if(value == null)
            {
                throw new ArgumentNullException();
            }
            list.AddFirst(value);
            Count++;
        }
    }
}