using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _01.ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private int currentIndex;
        private List<T> Items;

        public ListyIterator(List<T> collection)
        {
            this.currentIndex = 0;
            this.Items = collection;
        }

        public int Count
        {
            get
            {
                return this.Items.Count;
            }
        }
        public bool Move()
        {
            if (this.HasNext())
            {
                this.currentIndex++;
                return true;
            }
            return false;
        }
        public bool HasNext()
        {
            if (this.currentIndex<this.Count-1)
            {
                return true;
            }
            return false;
        }
        public void Print()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(this.Items[this.currentIndex]);
        }
        public void PrintAll()
        {
            foreach (var item in Items)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                yield return Items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
