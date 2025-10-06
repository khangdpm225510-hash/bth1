using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490_NguyễnThịHuỳnhTrân_Real11_Flyweight
{
    public class CharacterDefault : Character
    {
        public CharacterDefault(char c)
        {
            symbol = c;
            height = 90;
            width = 90;
            ascent = 60;
            descent = 0;
        }

        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Console.WriteLine($"{symbol} (default, point size {this.pointSize})");
        }
    }
}
