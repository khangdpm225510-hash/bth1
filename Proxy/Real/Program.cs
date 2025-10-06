using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490_NguyễnThịHuỳnhTrân_Real12_Proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tạo proxy toán học
            MathProxy proxy = new MathProxy();

            // Thực hiện tính toán
            Console.WriteLine("8 + 3 = " + proxy.Add(8, 3));
            Console.WriteLine("8 - 3 = " + proxy.Sub(8, 3));
            Console.WriteLine("8 * 3 = " + proxy.Mul(8, 3));
            Console.WriteLine("8 / 3 = " + proxy.Div(8, 3));

            // Chờ người dùng
            Console.ReadKey();
        }
    }

}
