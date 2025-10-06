using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld01
{
    class FuelTank : FuelSystem
    {
        public override void SupplyFuel(Engine engine)
        {
            Console.WriteLine("⛽ FuelTank supplying fuel to " + engine.GetType().Name);
            engine.Start();
        }
    }
}
