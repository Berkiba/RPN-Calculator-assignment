using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Model.Exceptions;
using DivideByZeroException = Calculator.Model.Exceptions.DivideByZeroException;

namespace Calculator.Model.Tokens
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
