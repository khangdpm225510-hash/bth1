using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490_NguyễnThịHuỳnhTrân_Patten11_Flyweight
{
    public class ChessPieceFactory
    {
        private Dictionary<string, ChessPiece> _pieces = new Dictionary<string, ChessPiece>();

        public ChessPiece GetChessPiece(string type)
        {
            if (!_pieces.ContainsKey(type))
            {
                _pieces[type] = new ConcreteChessPiece(type);
            }
            return _pieces[type];
        }
    }
}
