using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490_NguyễnThịHuỳnhTrân_Patten12_Proxy
{
    public class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("RealSubject: Thực thi yêu cầu thật sự.");
        }
    }
}
