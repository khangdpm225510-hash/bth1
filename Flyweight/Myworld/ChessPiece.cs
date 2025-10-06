using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490_NguyễnThịHuỳnhTrân_MyWorld11_ChessPieces
{
    public abstract class ChessPiece
    {
        protected string name;
        protected string color;

        public abstract void Display(int x, int y);
    }
}
