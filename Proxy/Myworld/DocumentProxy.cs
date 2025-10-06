using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490_NguyễnThịHuỳnhTrân_MyWorld12_Proxy
{
    public class DocumentProxy : Document
    {
        private RealDocument _realDocument;
        private string _content;
        private bool _isAuthenticated = false;

        public DocumentProxy(string content)
        {
            _content = content;
        }

        public void Login(string username, string password)
        {
            // Giả lập kiểm tra tài khoản
            if (username == "tran" && password == "12345")
            {
                Console.WriteLine("Đăng nhập thành công!");
                _isAuthenticated = true;
            }
            else
            {
                Console.WriteLine("Sai tài khoản hoặc mật khẩu!");
            }
        }
        public override void Display()
        {
            if (!_isAuthenticated)
            {
                Console.WriteLine("Truy cập bị từ chối. Vui lòng đăng nhập!");
                return;
            }

            // Khởi tạo RealDocument khi cần (lazy load)
            if (_realDocument == null)
            {
                _realDocument = new RealDocument(_content);
            }
            _realDocument.Display();
        }
    }
}
