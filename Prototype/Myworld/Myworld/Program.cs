using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myworld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Su dung adapter de doc cac loai file khac nhau
            IFileReader reader;

            reader = new FileAdapter("tailieu.txt");
            reader.Read();

            reader = new FileAdapter("bao_cao.pdf");
            reader.Read();

            reader = new FileAdapter("hopdong.docx");
            reader.Read();

            Console.ReadKey();
        }
    }
}
