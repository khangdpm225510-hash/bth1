using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nguyen_Thi_Huynh_Tran_DPM225490_Real10_Facade_Design
{
    public class HotelBooking
    {
        public bool ReserveHotel(Customer c, string destination)
        {
            Console.WriteLine($"Đặt khách sạn cho {c.Name} tại {destination}");
            return true;
        }
    }
}
