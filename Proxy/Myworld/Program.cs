using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DPM225490_NguyễnThịHuỳnhTrân_MyWorld12_Proxy
{
    using System;

    namespace DPM225490_NguyenThiHuynhTran_MyWorld12_Proxy
    {
        /// <summary>
        /// Proxy Pattern - MyWorld Example (chỉ dùng class, không interface)
        /// DPM225490 - Nguyễn Thị Huỳnh Trân - MyWorld12 Proxy
        /// </summary>
        public class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("=== Hệ thống quản lý tài liệu (Proxy) ===");

                // Người dùng chưa đăng nhập
                DocumentProxy doc1 = new DocumentProxy("Báo cáo mật - Kế hoạch 2025");
                doc1.Display();

                Console.WriteLine("\n--- Người dùng đăng nhập ---");
                DocumentProxy doc2 = new DocumentProxy("Báo cáo mật - Kế hoạch 2025");
                doc2.Login("tran", "12345");   // login với user và password
                doc2.Display();

                Console.ReadKey();
            }
        }
    }
}
