using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        

        public IEnumerator<Book> GetEnumerator()
        {
            
            return new LibraryIterator(this.books);
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }




        private class LibraryIterator : IEnumerator<Book>
        {
            private int currentIndex;
            private readonly List<Book> books;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books);
            }



            public object Current => this.Current;

            Book IEnumerator<Book>.Current => this.books[currentIndex];

            public void Dispose()
            {

            }

            public bool MoveNext()
            {
                currentIndex++;
                if (currentIndex >= books.Count)
                {
                    return false;
                }
                return true;
            }
            


            public void Reset()
            {
                currentIndex = -1;
            }


        }
    }
}