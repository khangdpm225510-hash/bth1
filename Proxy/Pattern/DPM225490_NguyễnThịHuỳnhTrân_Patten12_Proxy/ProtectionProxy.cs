using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490_NguyễnThịHuỳnhTrân_Patten12_Proxy
{
    public class ProtectionProxy : Subject
    {
        private RealSubject realSubject;
        private string role;

        public ProtectionProxy(string role)
        {
            this.role = role;
        }

        public override void Request()
        {
            if (role == "admin")
            {
                // Chỉ admin mới được gọi thật sự
                if (realSubject == null)
                {
                    realSubject = new RealSubject();
                }
                Console.WriteLine("Proxy: Quyền hợp lệ, chuyển tiếp yêu cầu...");
                realSubject.Request();
            }
            else
            {
                Console.WriteLine("Proxy: Truy cập bị từ chối. Bạn không có quyền.");
            }
        }
    }
}
