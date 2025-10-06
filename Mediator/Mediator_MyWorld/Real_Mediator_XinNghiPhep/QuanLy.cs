using System;

namespace Real_Mediator_XinNghiPhep
{
    public class QuanLy : NhanVien
    {
        public QuanLy(IMediator mediator, string ten) : base(mediator, ten, "QuanLy") { }

        public void XuLyYeuCau(string yeuCau)
        {
            Console.WriteLine("Quan Ly xu ly yeu cau: " + yeuCau);
            if (yeuCau.Contains("3 ngay"))
            {
                Console.WriteLine("Quan Ly: Yeu cau vuot qua quyen han, chuyen len Giam Doc");
                mediator.GuiYeuCau(yeuCau, this);
            }
        }
    }
}
