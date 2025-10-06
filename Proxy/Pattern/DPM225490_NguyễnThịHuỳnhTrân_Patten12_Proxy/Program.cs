using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DPM225490_NguyễnThịHuỳnhTrân_Patten12_Proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Proxy Pattern Demo ===");

            // Tạo proxy thay cho RealSubject
            Subject proxy = new ProtectionProxy("student");
            proxy.Request();

            Console.WriteLine();

            Subject proxy2 = new ProtectionProxy("admin");
            proxy2.Request();

            Console.ReadKey();
        }
    }
}
