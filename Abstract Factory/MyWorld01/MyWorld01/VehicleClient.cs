using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld01
{
    class VehicleClient
    {
        private Engine _engine;
        private FuelSystem _fuelSystem;

        public VehicleClient(VehicleFactory factory)
        {
            _engine = factory.CreateEngine();
            _fuelSystem = factory.CreateFuelSystem();
        }

        public void Run()
        {
            _fuelSystem.SupplyFuel(_engine);
        }
    }
}
