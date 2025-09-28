using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculator.Model.Tokens.EmptyTokenClass;

namespace Calculator.Model.Tokens
{
    internal class Operand
    {
        public class Operand : Token
        {
            public double Value;

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
}
