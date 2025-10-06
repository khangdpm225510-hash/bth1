using System;

namespace Real_Mediator_XinNghiPhep
{
    public class GiamDoc : NhanVien
    {
        public GiamDoc(IMediator mediator, string ten) : base(mediator, ten, "GiamDoc") { }

        public void XuLyYeuCau(string yeuCau)
        {
            Console.WriteLine("Giam Doc phe duyet yeu cau: " + yeuCau);
        }
    }
}
