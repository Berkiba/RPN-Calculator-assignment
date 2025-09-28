using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Model.Exceptions;
using static Calculator.Model.Exceptions.InvalidTokenExpetion;
using static Calculator.Model.Tokens.EmptyTokenClass;
using static Calculator.Model.Tokens.MultiplyOperator;
using static Calculator.Model.Tokens.SubtractOperator;
using static Calculator.Model.Tokens.AddOperator;
using static Calculator.Model.Tokens.ModulusOperator;
using static Calculator.Model.Tokens.DivideOperator;
using static Calculator.Model.Tokens.Operand;
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

            string[] parts = expression.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string part in parts)
            {
                Token token = ParseToken(part);
                stack.Push(token);
            }

            return Evaluate();
        }

        private Token ParseToken(string part)
        {
            double number;
            if (double.TryParse(part, out number))
            {
                return new Operand(number);
            }

            if (part == "+") return new AddOperator();
            if (part == "-") return new SubtractOperator();
            if (part == "*") return new MultiplyOperator();
            if (part == "/") return new DivideOperator();
            if (part == "%") return new ModulusOperator();

            throw new InvalidTokenException(part);
        }

        private double Evaluate()
        {
            RpnStack<double> values = new RpnStack<double>();

            while (!stack.IsEmpty())
            {
                Token token = stack.Pop();

                if (token is Operand opnd)
                {
                    values.Push(opnd.Value);
                }
                else if (token is Operator op)
                {
                    if (values.IsEmpty()) throw new InvalidOperationException();
                    double right = values.Pop();
                    if (values.IsEmpty()) throw new InvalidOperationException();
                    double left = values.Pop();

                    double result = op.Calculate(left, right);
                    values.Push(result);
                }
            }

            if (values.IsEmpty()) throw new InvalidOperationException();
            return values.Pop();
        }
    }
}
