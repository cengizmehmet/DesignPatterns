using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern_Infix
{
    public class Parser
    {
        public ExpressionBase Parse(string polish)
        {
            List<string> symbols = new List<string>(polish.Split(' '));
            return ParseNextExpression(symbols);
        }

        public ExpressionBase ParseNextExpression(List<string> symbols)
        {
            int value;
            if (int.TryParse(symbols[0], out value))
            {
                symbols.RemoveAt(0);
                return new IntegerExpression(value);
            }
            else
            {
                return ParseNonTerminalExpression(symbols);
            }
        }

        private ExpressionBase ParseNonTerminalExpression(List<string> symbols)
        {
            string symbol = symbols[0];
            symbols.RemoveAt(0);

            ExpressionBase expr1 = ParseNextExpression(symbols);
            ExpressionBase expr2 = ParseNextExpression(symbols);

            switch (symbol)
            {
                case "+":
                    return new AdditionExpression(expr1, expr2);
                case "-":
                    return new SubtractionExpression(expr1, expr2);
                default:
                    string message = string.Format("Invalid Symbol ({0})", symbol);
                    throw new InvalidOperationException(message);
            }
        }
    }
}
