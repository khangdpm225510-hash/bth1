using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nguyen_Thi_Huynh_Tran_DPM225490_Real10_Facade_Design
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Facade
            TravelFacade travel = new TravelFacade();

            // Customer muốn đặt chuyến đi
            Customer customer = new Customer("Nguyen Tran");

            bool booked = travel.BookTrip(customer, "Hà Nội", "Đà Nẵng");

            Console.WriteLine("\n" + customer.Name +
                (booked ? " đã đặt chuyến đi thành công!" : " đặt chuyến đi thất bại."));

            Console.ReadKey();
        }
    }
}
