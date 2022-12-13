using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queue
{
    public class Queue<T>
    {
        private readonly IQueue<T> queue;
        public int Count => queue.Count;

        public Queue(IQueueType type = IQueueType.Array)
        {
            if(type == IQueueType.Array)
            {
                queue = new ArrayQueue<T>();
            }
            else
            {
                queue = new LinkedListQueue<T>();
            }
        }

        public void EnQueue(T value)
        {
            queue.EnQueue(value);
        }
        public T DeQueue()
        {
            return queue.DeQueue();
        }
        public T Peek()
        {
            return queue.Peek();
        }
    }

    public interface IQueue<T>
    {
        int Count { get; }
        void EnQueue(T value);
        T DeQueue();
        T Peek();
    }

    public enum IQueueType
    {
        Array = 0,          //list<T>
        LinkedList = 1      //DoublyLinkedList
    }
}
