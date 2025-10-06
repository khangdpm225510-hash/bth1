using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490_NguyễnThịHuỳnhTrân_Patten11_Flyweight
{
    public class ConcreteChessPiece : ChessPiece
    {
        public ConcreteChessPiece(string type)
        {
            this.Type = type;
        }

        public override void Display(int x, int y)
        {
            Console.WriteLine($"ChessPiece {Type} at ({x}, {y})");
        }
    }
}
