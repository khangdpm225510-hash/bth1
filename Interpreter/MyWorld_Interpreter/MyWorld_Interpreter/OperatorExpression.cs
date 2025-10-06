using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld_Interpreter
{
    public class OperatorExpression : Expression
    {
        public override void Interpret(Context context)
        {
            var tokens = context.Input.Split(' ');

            int result = context.Output;

            for (int i = 1; i < tokens.Length; i += 2)
            {
                string op = tokens[i];
                int num = int.Parse(tokens[i + 1]);

                if (op == "+")
                {
                    result += num;
                }
                else if (op == "-")
                {
                    result -= num;
                }
            }

            context.Output = result;
        }
    }
}
