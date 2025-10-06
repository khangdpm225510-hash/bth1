using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld2
{
    class LuxuryTourBuilder : TourBuilder
    {
        public LuxuryTourBuilder()
        {
            _tour = new Tour("Luxury Tour");
        }

        public override void BuildFlight()
        {
            _tour["flight"] = "Vé máy bay hạng thương gia";
        }

        public override void BuildHotel()
        {
            _tour["hotel"] = "Khách sạn 5 sao";
        }

        public override void BuildMeals()
        {
            _tour["meals"] = "Ẩm thực cao cấp";
        }

        public override void BuildActivities()
        {
            _tour["activities"] = "Du thuyền + Spa + Golf";
        }
    }
}
