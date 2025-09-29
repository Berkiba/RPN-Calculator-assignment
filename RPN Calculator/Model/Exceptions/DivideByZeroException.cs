using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator.Model.Exceptions
{
    //Custom exception for divide by zero errors
    public class DivideByZeroException : Exception
    {
        public double Left { get; }
        public double Right { get; }

        public DivideByZeroException(double left, double right)
            : base($"DivideByZeroException: {left:0.00}/{right:0.00}")
        {
            Left = left;
            Right = right;
        }
    }
}

