using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld
{
    public abstract class ShippingStrategy
    {
        public abstract void CalculateShippingCost();
    }
}
