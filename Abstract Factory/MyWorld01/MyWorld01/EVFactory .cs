using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld01
{
  
        class EVFactory : VehicleFactory
        {
            public override Engine CreateEngine()
            {
                return new ElectricEngine();
            }
            public override FuelSystem CreateFuelSystem()
            {
                return new Battery();
            }
        }
    
}
