using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_3
{
    public class MyQueue<T> : IEnumerator<T>, IEnumerable<T>
    {
        // Fields and Consts

        public List<T> queue;
        private int capacity;
        private int count;
        private const int DEFAULT_CAPACITY = 32;

        // Properties

        public int Capacity
        {
            get;
            set;
        }
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }

        }

        // Ctors

        public MyQueue()
        {
            queue = new List<T>(DEFAULT_CAPACITY);
            capacity = DEFAULT_CAPACITY;
        }
        public MyQueue(int capacity)
        {
            queue = new List<T>(capacity);
            this.capacity = capacity;
        }
        public MyQueue(MyQueue<T> collection) //?
        {
            IEnumerator<T> ienum = queue.GetEnumerator();

            while (ienum.MoveNext())
                queue.Add(ienum.Current);
        }

        // Methods

        public bool Contains(T item)
        {
            if (queue.Contains(item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Clear()
        {
            queue.Clear();
            Count = 0;
        }

        public T Dequeue()
        {
            T buf = queue[0];
            queue.RemoveAt(0);
            count--;
            return buf;
        }

        public void Enqueue(object item)
        {
            T i = (T)item;
            queue.Add(i);
            count++;
        }

        public T Peek()
        {
            return queue[0];
        }

        public T[] ToArray()
        {
            T[] array = queue.ToArray();
            return array;
        }

        public List<T> Clone()
        {
            return queue;
        }

        public void CopyTo(Array array, int arrayIdx)
        {
            if (array.Length - arrayIdx < Count)
            {
                throw new System.IndexOutOfRangeException();
            }
            else
            {
                T[] Tarr = (T[])array;
                queue.CopyTo(Tarr, arrayIdx);
            }
        }

        // IEnumerator realization

        private int currentIdx; // С нулевого
        public T Current
        {
            get
            {
                return queue[currentIdx];
            }
        }
        object IEnumerator.Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            if (currentIdx >= count - 1)
            {
                return false;
            }
            else
            {
                currentIdx++;
                return true;
            }
        }

        public void Reset()
        {
            currentIdx = 0;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        // IEnumerable<T> realization

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)queue).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)queue).GetEnumerator();
        }
    }
}
