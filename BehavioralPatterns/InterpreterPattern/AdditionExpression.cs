using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern_Infix
{
    public class AdditionExpression : ExpressionBase
    {
        ExpressionBase _expr1;
        ExpressionBase _expr2;

        public AdditionExpression(ExpressionBase expr1, ExpressionBase expr2)
        {
            _expr1 = expr1;
            _expr2 = expr2;
        }

        public override int Evaluate()
        {
            int value1 = _expr1.Evaluate();
            int value2 = _expr2.Evaluate();
            return value1 + value2;
        }

        public override string ToString()
        {
            return string.Format("({0} + {1})", _expr1, _expr2);
        }
    }
}
