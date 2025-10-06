using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490_NguyễnThịHuỳnhTrân_MyWorld11_ChessPieces
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PieceFactory factory = new PieceFactory();

            // Bàn cờ: mỗi quân cờ được tạo chỉ 1 lần, nhưng có thể đặt nhiều vị trí khác nhau
            ChessPiece whiteKing = factory.GetPiece("WhiteKing");
            whiteKing.Display(4, 0);

            ChessPiece blackKing = factory.GetPiece("BlackKing");
            blackKing.Display(4, 7);

            ChessPiece whitePawn = factory.GetPiece("WhitePawn");
            for (int i = 0; i < 8; i++)
            {
                whitePawn.Display(i, 1);
            }

            ChessPiece blackPawn = factory.GetPiece("BlackPawn");
            for (int i = 0; i < 8; i++)
            {
                blackPawn.Display(i, 6);
            }

            Console.ReadKey();
        }
    }
}
