using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld2
{
    class TravelAgency
    {
        public void Construct(TourBuilder builder)
        {
            builder.BuildFlight();
            builder.BuildHotel();
            builder.BuildMeals();
            builder.BuildActivities();
        }
    }
}
