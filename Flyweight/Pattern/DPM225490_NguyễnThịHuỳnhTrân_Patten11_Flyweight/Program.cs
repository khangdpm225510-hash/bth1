using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490_NguyễnThịHuỳnhTrân_Patten11_Flyweight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ChessPieceFactory factory = new ChessPieceFactory();

            // Lấy quân cờ King (chỉ tạo 1 lần, dùng lại nhiều lần)
            ChessPiece king = factory.GetChessPiece("King");
            king.Display(1, 1);  // Vị trí khác nhau

            ChessPiece king2 = factory.GetChessPiece("King");
            king2.Display(5, 7);

            // Lấy quân cờ Queen
            ChessPiece queen = factory.GetChessPiece("Queen");
            queen.Display(3, 4);

            // Quân cờ tùy chỉnh không dùng chung
            UnsharedChessPiece custom = new UnsharedChessPiece("Custom");
            custom.Display(8, 8);

            Console.ReadKey();
        }
    }
}
