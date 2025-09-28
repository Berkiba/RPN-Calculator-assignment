using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculator.Model.Tokens.EmptyTokenClass;

namespace Calculator.Model.Tokens
{
    internal class Operator
    {
        // Base class for operators
        public class Operator : Token
        {
            public string Symbol;

            public Operator(string symbol)
            {
                Symbol = symbol;
            }

            public virtual double Calculate(double a, double b)
            {
                return 0; // overridden in subclasses
            }

            public override string ToString()
            {
                return Symbol;
            }
        }
    }
}
