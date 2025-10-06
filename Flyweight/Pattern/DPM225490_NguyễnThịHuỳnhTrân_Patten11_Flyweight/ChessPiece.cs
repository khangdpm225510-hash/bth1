using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490_NguyễnThịHuỳnhTrân_Patten11_Flyweight
{
    public abstract class ChessPiece
    {
        protected string Type; // intrinsic state

        public abstract void Display(int x, int y); // extrinsic state
    }
}
