using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld01
{
    class Battery : FuelSystem
    {
        public override void SupplyFuel(Engine engine)
        {
            Console.WriteLine("🔋 Battery supplying power to " + engine.GetType().Name);
            engine.Start();
        }
    }
}
