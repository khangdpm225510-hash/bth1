using System;

namespace Real_Mediator_XinNghiPhep
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();

            QuanLy ql = new QuanLy(mediator, "Quan Ly A");
            GiamDoc gd = new GiamDoc(mediator, "Giam Doc B");
            NhanVien nv = new NhanVien(mediator, "Nhan Vien C", "NhanVien");

            mediator.DangKyQuanLy(ql);
            mediator.DangKyGiamDoc(gd);

            Console.WriteLine("Nhan vien gui yeu cau nghi 1 ngay:");
            nv.GuiYeuCau("Xin nghi 1 ngay");

            Console.WriteLine("\nNhan vien gui yeu cau nghi 3 ngay:");
            nv.GuiYeuCau("Xin nghi 3 ngay");
        }
    }
}
