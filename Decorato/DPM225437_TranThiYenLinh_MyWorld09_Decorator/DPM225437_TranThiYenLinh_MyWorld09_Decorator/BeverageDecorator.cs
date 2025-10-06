using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225437_TranThiYenLinh_MyWorld09_Decorator
{
    public abstract class BeverageDecorator : Beverage
    {
        protected Beverage beverage;

        public BeverageDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription();
        }

        public override double GetCost()
        {
            return beverage.GetCost();
        }
    }

}
