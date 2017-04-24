using System;
using System.Collections.Generic;

namespace MyStack
{
    public class MyStack<T> : IMyStack<T>

    {
        LinkedList<T> list;

        private int maxStackSize;

        public MyStack(int maxStackSize)
        {
            this.maxStackSize = maxStackSize;
            list = new LinkedList<T>();
        }

        public void Clear()
        {
            list.Clear();
        }

        public T Pop()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("The Stack is empty");
            }
            T value = list.First.Value;
            list.RemoveFirst();
            return value;
        }

        public void Push(T item)
        {
            if (list.Count < maxStackSize)
            {
                list.AddFirst(item);
            }
            else
            {
                throw new InvalidOperationException("The Stack is full");
            }
        }

        public int Size()
        {
            return list.Count;
        }

        public T Top()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("The Stack is empty");
            }
            return list.First.Value;
        }
    }
}
