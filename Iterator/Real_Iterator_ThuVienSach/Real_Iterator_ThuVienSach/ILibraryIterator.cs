namespace Real_Iterator_ThuVienSach
{
    public interface ILibraryIterator
    {
        Book First();
        Book Next();
        bool IsDone { get; }
        Book CurrentBook { get; }
    }
}
