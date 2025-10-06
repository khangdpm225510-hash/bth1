using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myworld
{
    public class FileAdapter : IFileReader
    {
        private OldFileReader adaptee;
        private string fileName;

        public FileAdapter(string fileName)
        {
            this.fileName = fileName;
            this.adaptee = new OldFileReader();
        }

        public void Read()
        {
            string ext = System.IO.Path.GetExtension(fileName).ToLower();

            switch (ext)
            {
                case ".txt":
                    adaptee.ReadText(fileName);
                    break;
                case ".pdf":
                    Console.WriteLine("Chuyen doi pdf sang text truoc khi doc...");
                    adaptee.ReadText(fileName);
                    break;
                case ".docx":
                    Console.WriteLine("Chuyen doi docx sang text truoc khi doc...");
                    adaptee.ReadText(fileName);
                    break;
                default:
                    Console.WriteLine("Khong ho tro dinh dang: " + ext);
                    break;
            }
        }
    }
}
