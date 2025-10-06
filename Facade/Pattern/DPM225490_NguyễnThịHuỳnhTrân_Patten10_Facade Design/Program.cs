using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490_NguyenThiHuynhTran_Patten10_Facade_Design
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Tạo Facade
            SignFacade signFacade = new SignFacade();

            // Gọi các phương thức thông qua Facade
            signFacade.DisplayWelcomeSign();
            signFacade.DisplayExitSign();

            Console.ReadLine();
        }
    }
}
