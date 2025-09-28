using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Model.Exceptions;

namespace Calculator.Model.Tokens
{
    internal class DivideOperator
    {
        public class DivideOperator : Operator
        {
            public DivideOperator() : base("/") { }

            public override double Calculate(double a, double b)
            {
                if (b == 0) throw new DivideByZeroException(a, b);
                return a / b;
            }
        }
    }
}
