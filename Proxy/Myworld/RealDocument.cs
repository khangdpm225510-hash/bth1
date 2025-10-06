using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490_NguyễnThịHuỳnhTrân_MyWorld12_Proxy
{
    public class RealDocument : Document
    {
        private string _content;

        public RealDocument(string content)
        {
            _content = content;
        }

        public override void Display()
        {
            Console.WriteLine("Nội dung tài liệu: " + _content);
        }
    }
}
