using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490_NguyễnThịHuỳnhTrân_MyWorld11_ChessPieces
{
    public class PieceFactory
    {
        private Dictionary<string, ChessPiece> pieces = new Dictionary<string, ChessPiece>();

        public ChessPiece GetPiece(string key)
        {
            if (pieces.ContainsKey(key))
            {
                return pieces[key];
            }
            else
            {
                ChessPiece piece = null;
                switch (key)
                {
                    case "WhiteKing": piece = new King("White"); break;
                    case "BlackKing": piece = new King("Black"); break;
                    case "WhitePawn": piece = new Pawn("White"); break;
                    case "BlackPawn": piece = new Pawn("Black"); break;
                    default: piece = new UnknownPiece("Unknown"); break;
                }
                pieces.Add(key, piece);
                return piece;
            }
        }
    }
}
