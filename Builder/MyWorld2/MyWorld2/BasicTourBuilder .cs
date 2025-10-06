using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld2
{
    class BasicTourBuilder : TourBuilder
    {
        public BasicTourBuilder()
        {
            _tour = new Tour("Basic Tour");
        }

        public override void BuildFlight()
        {
            _tour["flight"] = "Vé máy bay hạng phổ thông";
        }

        public override void BuildHotel()
        {
            _tour["hotel"] = "Khách sạn 3 sao";
        }

        public override void BuildMeals()
        {
            _tour["meals"] = "Ăn uống bình dân";
        }

        public override void BuildActivities()
        {
            _tour["activities"] = "Tham quan thành phố";
        }
    }


}
