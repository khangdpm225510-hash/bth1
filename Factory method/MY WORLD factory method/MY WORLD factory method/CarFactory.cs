using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MY_WORLD_factory_method.Vehicle;

namespace MY_WORLD_factory_method
{

        public class CarFactory : VehicleFactory
        {
            public override void CreateVehicle()
            {
                Vehicle = new Car();
                Vehicle.Features.Add("4 wheels");
                Vehicle.Features.Add("Air conditioning");
                Vehicle.Features.Add("Radio");
            }
        }
    }

