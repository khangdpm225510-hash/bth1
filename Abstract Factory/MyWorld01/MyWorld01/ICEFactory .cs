using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld01
{
    class ICEFactory : VehicleFactory
    {
        public override Engine CreateEngine()
        {
            return new GasEngine();
        }
        public override FuelSystem CreateFuelSystem()
        {
            return new FuelTank();
        }
    }
}
