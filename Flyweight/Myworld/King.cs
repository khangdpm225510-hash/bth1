using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490_NguyễnThịHuỳnhTrân_MyWorld11_ChessPieces
{
    public class King : ChessPiece
    {
        public King(string color)
        {
            this.name = "King";
            this.color = color;
        }

        public override void Display(int x, int y)
        {
            Console.WriteLine($"{color} {name} at position ({x}, {y})");
        }
    }
}
