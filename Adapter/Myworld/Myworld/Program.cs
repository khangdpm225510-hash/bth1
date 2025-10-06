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
            IFileReader reader;

            reader = new FileAdapter("baitap1.txt");
            reader.Read();

            reader = new FileAdapter("baitap2.pdf");
            reader.Read();

            reader = new FileAdapter("baitap3.docx");
            reader.Read();

            Console.ReadKey();
        }
    }
}
