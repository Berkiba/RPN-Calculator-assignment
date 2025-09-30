using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model.Tokens
{
    //Basic add function, returning double
    public class AddOperator : Operator
    {
        public AddOperator() : base("+") { }
        public override double Calculate(double a, double b) => a + b;
    }

}
