using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MY_WORLD_factory_method.Vehicle;

namespace MY_WORLD_factory_method
{

        public class BikeFactory : VehicleFactory
        {
            public override void CreateVehicle()
            {
                Vehicle = new Bike();
                Vehicle.Features.Add("2 wheels");
                Vehicle.Features.Add("No air conditioning");
                Vehicle.Features.Add("Manual transmission");
            }
        }
    }
