using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator.Model.Tokens
{

    public class MultiplyOperator : Operator
    {
        public MultiplyOperator() : base("*") { }
        public override double Calculate(double a, double b) => a * b;
    }

}
