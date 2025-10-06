using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Command
{
    public class CalculatorCommand : Command
    {
        char @operator;
        int operand;
        Calculator calculator;

        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            this.calculator = calculator;
            this.@operator = @operator;
            this.operand = operand;
        }

        public override void Execute() => calculator.Operation(@operator, operand);

        public override void UnExecute() => calculator.Operation(Undo(@operator), operand);

        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("@operator");
            }
        }
    }
}
