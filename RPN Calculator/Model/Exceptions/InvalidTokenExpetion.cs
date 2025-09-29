using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model.Exceptions
{

    public class InvalidTokenException : Exception
    {
        public InvalidTokenException(string token)
            : base("InvalidTokenException: " + token)
        {
        }
    }

}
