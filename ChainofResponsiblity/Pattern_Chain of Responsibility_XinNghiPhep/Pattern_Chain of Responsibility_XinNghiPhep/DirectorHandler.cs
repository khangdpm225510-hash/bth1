using System;

namespace Pattern_ChainOfResponsibility_XinNghiPhep
{
    public class DirectorHandler : Handler
    {
        public override void XuLyYeuCau(LeaveRequest request)
        {
            if (request.SoNgay > 5)
            {
                Console.WriteLine($"Giam doc da duyet cho {request.TenNhanVien} nghỉ {request.SoNgay} ngày.");
            }
            else if (successor != null)
            {
                successor.XuLyYeuCau(request);
            }
        }
    }
}
