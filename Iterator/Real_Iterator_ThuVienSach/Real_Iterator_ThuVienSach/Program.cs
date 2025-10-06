using System;

namespace Real_Iterator_ThuVienSach
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            Library library = new Library();
            library[0] = new Book("Lap trinh C#");
            library[1] = new Book("Cau truc du lieu");
            library[2] = new Book("Thiet ke he thong");
            library[3] = new Book("Mang may tinh");
            library[4] = new Book("Co so du lieu");
            library[5] = new Book("Tri tue nhan tao");

          
            LibraryIterator iterator = library.CreateIterator();

            iterator.Step = 2;

            Console.WriteLine("Danh sach sach trong thu vien (Cach 2 cuon): ");

            for (Book book = iterator.First(); !iterator.IsDone; book = iterator.Next())
            {
                Console.WriteLine(book.Title);
            }

            Console.ReadKey();
        }
    }
}
