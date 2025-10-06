using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nguyen_Thi_Huynh_Tran_DPM225490_Real10_Facade_Design
{
    public class TravelFacade
    {
        private FlightBooking flight;
        private HotelBooking hotel;
        private CarRental car;

        public TravelFacade()
        {
            flight = new FlightBooking();
            hotel = new HotelBooking();
            car = new CarRental();
        }

        public bool BookTrip(Customer cust, string from, string to)
        {
            Console.WriteLine($"{cust.Name} yêu cầu đặt chuyến đi từ {from} đến {to}\n");

            bool success = true;

            if (!flight.ReserveFlight(cust, from, to))
                success = false;

            if (!hotel.ReserveHotel(cust, to))
                success = false;

            if (!car.ReserveCar(cust, to))
                success = false;

            return success;
        }
    }
}
