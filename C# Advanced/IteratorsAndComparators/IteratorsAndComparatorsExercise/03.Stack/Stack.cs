using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _03.Stack
{
    class Stack<T> : IEnumerable<T>
    {
        public  List<T> items = new List<T>();

        public void Push(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                items.Add(arr[i]);
            }
        }
        public T Pop()
        {
            int index = items.Count - 1;
            T element = items[index];
            items.Remove(element);
            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = items.Count - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
