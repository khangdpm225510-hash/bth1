using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490_NguyễnThịHuỳnhTrân_Real12_Proxy
{
    public class MathProxy : AbstractMath
    {
        private MathReal math = new MathReal();

        public override double Add(double x, double y)
        {
            Console.WriteLine($"[Proxy] Đang cộng {x} và {y}");
            return math.Add(x, y);
        }

        public override double Sub(double x, double y)
        {
            Console.WriteLine($"[Proxy] Đang trừ {x} và {y}");
            return math.Sub(x, y);
        }

        public override double Mul(double x, double y)
        {
            Console.WriteLine($"[Proxy] Đang nhân {x} và {y}");
            return math.Mul(x, y);
        }

        public override double Div(double x, double y)
        {
            Console.WriteLine($"[Proxy] Đang chia {x} cho {y}");
            return math.Div(x, y);
        }
    }
}

