using System.Collections.Generic;

namespace Real_Iterator_ThuVienSach
{
    public class Library : ILibraryCollection
    {
        private List<Book> books = new List<Book>();

        public LibraryIterator CreateIterator()
        {
            return new LibraryIterator(this);
        }

        public int Count
        {
            get { return books.Count; }
        }

        public Book this[int index]
        {
            get { return books[index]; }
            set { books.Add(value); }
        }
    }
}
