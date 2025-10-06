using System;

namespace Pattern_ChainOfResponsibility_XinNghiPhep
{
    public class LeaderHandler : Handler
    {
        public override void XuLyYeuCau(LeaveRequest request)
        {
            if (request.SoNgay <= 2)
            {
                Console.WriteLine($"Truong nhom da duyet cho {request.TenNhanVien} nghỉ {request.SoNgay} ngày.");
            }
            else if (successor != null)
            {
                successor.XuLyYeuCau(request);
            }
        }
    }
}
