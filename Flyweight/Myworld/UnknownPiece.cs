using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490_NguyễnThịHuỳnhTrân_MyWorld11_ChessPieces
{
    public class UnknownPiece : ChessPiece
    {
        public UnknownPiece(string color)
        {
            this.name = "Unknown";
            this.color = color;
        }

        public override void Display(int x, int y)
        {
            Console.WriteLine($"{color} {name} at position ({x}, {y})");
        }
    }
}

