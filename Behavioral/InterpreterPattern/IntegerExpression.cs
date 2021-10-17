using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern_Infix
{
    public class IntegerExpression : ExpressionBase
    {
        int _value;

        public IntegerExpression(int value)
        {
            _value = value;
        }

        public override int Evaluate()
        {
            return _value;
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}
