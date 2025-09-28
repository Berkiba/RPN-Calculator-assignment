using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model.Exceptions
{
    internal class DivideByZeroException
    {
        public class DivideByZeroException : Exception
        {
            public DivideByZeroException(double left, double right)
                : base($"DivideByZeroException: {left:0.00}/{right:0.00}")
            {
            }
        }
    }
}
