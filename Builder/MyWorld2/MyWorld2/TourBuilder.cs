using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld2
{
    abstract class TourBuilder
    {
        protected Tour _tour;

        public Tour Tour => _tour;

        public abstract void BuildFlight();
        public abstract void BuildHotel();
        public abstract void BuildMeals();
        public abstract void BuildActivities();
    }
}
