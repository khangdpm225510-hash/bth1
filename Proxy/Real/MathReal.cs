using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490_NguyễnThịHuỳnhTrân_Real12_Proxy
{
    public class MathReal : AbstractMath
    {
        public override double Add(double x, double y) { return x + y; }
        public override double Sub(double x, double y) { return x - y; }
        public override double Mul(double x, double y) { return x * y; }
        public override double Div(double x, double y) { return x / y; }
    }
}
