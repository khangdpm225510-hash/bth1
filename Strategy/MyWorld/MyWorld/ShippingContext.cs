using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld
{
    public class ShippingContext
    {
        private ShippingStrategy _shippingStrategy;

        // Constructor
        public ShippingContext(ShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        // Context method that delegates to the strategy's method
        public void CalculateShippingCost()
        {
            _shippingStrategy.CalculateShippingCost();
        }
    }
}
