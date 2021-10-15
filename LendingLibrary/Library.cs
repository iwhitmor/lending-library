using System.Collections;
using System.Collections.Generic;

namespace LendingLibrary
{
    public class Library : ILibrary
    {
        public int Count => throw new System.NotImplementedException();

        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            throw new System.NotImplementedException();
        }

        public Book Borrow(string title)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        public void Return(Book book)
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
