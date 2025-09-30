using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculator.Model.Tokens.Token;

namespace Calculator.Model.Tokens
{
    // Numeric operand in the RPN expression
    public class Operand : Token
    {
        public double Value { get; }

        public Operand(double value)
        {
            Value = value;
        }
        public override string ToString()
        {
            return Value.ToString("0.00");
        }
    }

}
