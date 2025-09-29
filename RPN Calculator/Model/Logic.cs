using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Model.Exceptions;
using Calculator.Model.Tokens;

namespace Calculator.Model
{

    public class Logic
    {
        private RpnStack<Token> stack;

        public Logic()
        {
            stack = new RpnStack<Token>();
        }

        public double Calculate(string expression)
        {
            stack.Clear();

            // Split expression
            var parts = expression.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string part in parts)
            {
                Token token = ParseToken(part);
                stack.Push(token);
            }

            // Evaluate 
            double result = EvaluateToken();

            // If anything remains
            if (!stack.IsEmpty())
                throw new InvalidOperationException();

            return result;
        }

        private Token ParseToken(string part)
        {
            if (double.TryParse(part, out double number))
                return new Operand(number);

            return part switch
            {
                "+" => new AddOperator(),
                "-" => new SubtractOperator(),
                "*" => new MultiplyOperator(),
                "/" => new DivideOperator(),
                "%" => new ModulusOperator(),
                _ => throw new InvalidTokenException(part)
            };
        }
        private double EvaluateToken()
        {
            if (stack.IsEmpty())
                throw new InvalidOperationException();

            Token token = stack.Pop();

            if (token is Operand opnd)
            {
                return opnd.Value;
            }
            else if (token is Operator op)
            {
                double right = EvaluateToken();
                double left = EvaluateToken();
                return op.Calculate(left, right);
            }

            throw new InvalidOperationException();
        }
    }

}
