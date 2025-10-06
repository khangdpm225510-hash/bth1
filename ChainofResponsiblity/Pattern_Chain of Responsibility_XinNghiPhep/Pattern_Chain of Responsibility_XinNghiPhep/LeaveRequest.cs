namespace Pattern_ChainOfResponsibility_XinNghiPhep
{
  
    public class LeaveRequest
    {
        public string TenNhanVien { get; set; }
        public int SoNgay { get; set; }

        public LeaveRequest(string tenNhanVien, int soNgay)
        {
            TenNhanVien = tenNhanVien;
            SoNgay = soNgay;
        }
    }
}
