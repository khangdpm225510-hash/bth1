using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nguyen_Thi_Huynh_Tran_DPM225490_Real10_Facade_Design
{
    public class CarRental
    {
        public bool ReserveCar(Customer c, string destination)
        {
            Console.WriteLine($"Thuê xe cho {c.Name} tại {destination}");
            return true;
        }
    }
}
