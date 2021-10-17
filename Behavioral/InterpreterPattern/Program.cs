using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern_Infix
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser parser = new Parser();
            string[] commands = new string[]
            {
                "+ 5 6",        //5 + 6
                "- 6 5",        //6 - 5
                "+ - 4 5 6",    //(4 - 5) + 6
                "+ 4 - 5 6",    //4 + (5 - 6)
                "+ - + - - 2 3 4 + - -5 6 + -7 8 9 10"
            };

            foreach (string command in commands)
            {
                ExpressionBase expression = parser.Parse(command);
                Console.WriteLine("{0} = {1}", expression, expression.Evaluate());
            }
        }
    }
}
