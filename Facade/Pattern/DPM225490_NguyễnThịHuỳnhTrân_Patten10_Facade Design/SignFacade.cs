using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490_NguyenThiHuynhTran_Patten10_Facade_Design
{
    public class SignFacade
    {
        private SubsystemSignA a;
        private SubsystemSignB b;
        private SubsystemSignC c;
        private SubsystemSignD d;

        public SignFacade()
        {
            a = new SubsystemSignA();
            b = new SubsystemSignB();
            c = new SubsystemSignC();
            d = new SubsystemSignD();
        }

        // Facade method 1
        public void DisplayWelcomeSign()
        {
            Console.WriteLine("\n--- Tạo Bảng hiệu WELCOME ---");
            a.DrawBorder();
            b.AddText();
            d.AddLight();
        }

        // Facade method 2
        public void DisplayExitSign()
        {
            Console.WriteLine("\n--- Tạo Bảng hiệu EXIT ---");
            a.DrawBorder();
            b.AddText();
            c.AddLogo();
        }
    }
}
