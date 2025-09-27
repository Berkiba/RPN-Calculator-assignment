using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    internal class Logic
    {
        public double Calculate(string input)
        {
            string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length == 3 && tokens[2] == "+")
            {
                double a = double.Parse(tokens[0]);
                double b = double.Parse(tokens[1]);
                return a + b;
            }
            // berkant gör det hät 
            return 0.0; // placeholder så det kompilerar
        }
    }
}
