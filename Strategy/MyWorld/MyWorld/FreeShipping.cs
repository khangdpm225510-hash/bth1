using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld
{
    public class FreeShipping : ShippingStrategy
    {
        public override void CalculateShippingCost()
        {
            Console.WriteLine("Calculating Free Shipping Cost: $0");
        }
    }
}
