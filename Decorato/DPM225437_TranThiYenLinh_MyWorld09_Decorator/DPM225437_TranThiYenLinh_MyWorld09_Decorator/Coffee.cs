using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225437_TranThiYenLinh_MyWorld09_Decorator
{
    public class Coffee : Beverage
    {
        public override string GetDescription()
        {
            return "Cà phê đen";
        }

        public override double GetCost()
        {
            return 20000; // giá 20k
        }
    }
}
