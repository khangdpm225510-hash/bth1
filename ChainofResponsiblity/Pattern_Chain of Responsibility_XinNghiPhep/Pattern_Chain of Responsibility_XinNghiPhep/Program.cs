using System;

namespace Pattern_ChainOfResponsibility_XinNghiPhep
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Handler truongNhom = new LeaderHandler();
            Handler quanLy = new ManagerHandler();
            Handler giamDoc = new DirectorHandler();

            truongNhom.SetSuccessor(quanLy);
            quanLy.SetSuccessor(giamDoc);

            
            LeaveRequest[] yeuCaus =
            {
                new LeaveRequest("An", 1),
                new LeaveRequest("Binh", 3),
                new LeaveRequest("Chi", 7)
            };

            foreach (var yc in yeuCaus)
            {
                truongNhom.XuLyYeuCau(yc);
            }

            Console.ReadKey();
        }
    }
}
