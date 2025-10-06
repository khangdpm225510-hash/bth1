using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld_Interpreter
{
    public class NumberExpression : Expression
    {
        public override void Interpret(Context context)
        {
            // Tách chuỗi thành tokens
            var tokens = context.Input.Split(' ');

            // Lấy số đầu tiên làm giá trị khởi đầu
            if (int.TryParse(tokens[0], out int number))
            {
                context.Output = number;
            }
        }
    }
}
