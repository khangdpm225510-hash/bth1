using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld01
{
    abstract class VehicleFactory
    {
        public abstract Engine CreateEngine();
        public abstract FuelSystem CreateFuelSystem();
    }
}
