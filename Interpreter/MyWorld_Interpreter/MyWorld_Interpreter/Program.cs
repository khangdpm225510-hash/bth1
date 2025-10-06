using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MyWorld_Interpreter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string expression = "5 + 3 - 2";
            Context context = new Context(expression);

            // Build parse tree
            List<Expression> tree = new List<Expression>();
            tree.Add(new NumberExpression());
            tree.Add(new OperatorExpression());

            // Interpret
            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine("{0} = {1}", expression, context.Output);
            Console.ReadKey();
        }
    }
}