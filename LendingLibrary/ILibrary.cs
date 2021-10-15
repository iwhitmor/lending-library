using System.Collections;
using System.Collections.Generic;

namespace LendingLibrary
{
    public interface ILibrary : IReadOnlyCollection<Book>
    {
        public int Count => throw new System.NotImplementedException();

        public IEnumerator<Book> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Add a Book to the library.
        /// </summary>
        void Add(string title, string firstName, string lastName, int numberOfPages);

        /// <summary>
        /// Remove a Book from the library with the given title.
        /// </summary>
        /// <returns>The Book, or null if not found.</returns>
        Book Borrow(string title);

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Return a Book to the library.
        /// </summary>
        void Return(Book book);
    }
}
