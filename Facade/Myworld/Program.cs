using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490__Nguyen_Thi_Huynh_Tran__MyWorld10_SmartHome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SmartHomeFacade smartHome = new SmartHomeFacade();

            Console.WriteLine("=== Kịch bản 1: Chủ nhà đi ra ngoài ===");
            smartHome.GoingOutMode();

            Console.WriteLine("\n=== Kịch bản 2: Xem phim tại nhà ===");
            smartHome.MovieNightMode();

            Console.ReadKey();
        }
    }
}
