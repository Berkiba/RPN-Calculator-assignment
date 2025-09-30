using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model.Exceptions
{
    // Custom exception for invalid tokens
    public class InvalidTokenException : Exception
    {
        public InvalidTokenException(string token)
            : base("InvalidTokenException: " + token)
        {
        }
    }

}
