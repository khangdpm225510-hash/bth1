using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225437_TranThiYenLinh_MyWorld09_Decorator
{
    public class Milk : BeverageDecorator
    {
        public Milk(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", thêm sữa";
        }

        public override double GetCost()
        {
            return beverage.GetCost() + 5000; // thêm 5k
        }
    }
}
