using System;

namespace Pattern_ChainOfResponsibility_XinNghiPhep
{
    public class ManagerHandler : Handler
    {
        public override void XuLyYeuCau(LeaveRequest request)
        {
            if (request.SoNgay <= 5)
            {
                Console.WriteLine($"Quan ly da duyet cho {request.TenNhanVien} nghỉ {request.SoNgay} ngày.");
            }
            else if (successor != null)
            {
                successor.XuLyYeuCau(request);
            }
        }
    }
}
