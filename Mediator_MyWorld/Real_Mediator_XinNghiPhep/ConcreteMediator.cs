using System;

namespace Real_Mediator_XinNghiPhep
{
    public class ConcreteMediator : IMediator
    {
        private QuanLy quanLy;
        private GiamDoc giamDoc;

        public void DangKyQuanLy(QuanLy ql)
        {
            quanLy = ql;
        }

        public void DangKyGiamDoc(GiamDoc gd)
        {
            giamDoc = gd;
        }

        public void GuiYeuCau(string yeuCau, NhanVien nhanVien)
        {
            if (nhanVien.CapBac == "NhanVien")
            {
                Console.WriteLine("Mediator: Gui yeu cau cua nhan vien den Quan Ly");
                quanLy.XuLyYeuCau(yeuCau);
            }
            else if (nhanVien.CapBac == "QuanLy")
            {
                Console.WriteLine("Mediator: Gui yeu cau cua Quan Ly den Giam Doc");
                giamDoc.XuLyYeuCau(yeuCau);
            }
        }
    }
}
