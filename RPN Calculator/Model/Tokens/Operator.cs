using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculator.Model.Tokens.Token;

namespace Calculator.Model.Tokens
{
    // Base class for all operators
    public abstract class Operator : Token
    {
        public string Symbol { get; }
        // Constructor to set the symbol property
        protected Operator(string symbol)
        {
            Symbol = symbol;
        }

        // Method to perform the operation
        public abstract double Calculate(double a, double b);

        public override string ToString() => Symbol;
    }

}
