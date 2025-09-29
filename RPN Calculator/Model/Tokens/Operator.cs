using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculator.Model.Tokens.Token;

namespace Calculator.Model.Tokens
{

    public abstract class Operator : Token
    {
        public string Symbol { get; }

        protected Operator(string symbol)
        {
            Symbol = symbol;
        }

        public abstract double Calculate(double a, double b);

        public override string ToString() => Symbol;
    }

}
