using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nguyen_Thi_Huynh_Tran_DPM225490_Real10_Facade_Design
{
    public class FlightBooking
    {
        public bool ReserveFlight(Customer c, string from, string to)
        {
            Console.WriteLine($"Đặt vé máy bay cho {c.Name} từ {from} đến {to}");
            return true;
        }
    }
}
