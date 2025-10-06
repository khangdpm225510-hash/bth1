using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld
{
    public class StandardShipping : ShippingStrategy
    {
        public override void CalculateShippingCost()
        {
            Console.WriteLine("Calculating Standard Shipping Cost: $5");
        }
    }
}
