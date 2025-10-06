namespace Real_Iterator_ThuVienSach
{
    public class LibraryIterator : ILibraryIterator
    {
        private Library library;
        private int current = 0;
        private int step = 1;

        public LibraryIterator(Library library)
        {
            this.library = library;
        }

        public Book First()
        {
            current = 0;
            return library[current];
        }

        public Book Next()
        {
            current += step;
            if (!IsDone)
                return library[current];
            else
                return null;
        }

        public int Step
        {
            get { return step; }
            set { step = value; }
        }

        public Book CurrentBook
        {
            get { return library[current]; }
        }

        public bool IsDone
        {
            get { return current >= library.Count; }
        }
    }
}
