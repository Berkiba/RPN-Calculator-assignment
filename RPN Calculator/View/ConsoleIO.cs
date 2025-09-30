using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Calculator.View
{
    public sealed class ConsoleInputReader : IOReader // läser en rad från konsolen
    {
        public string? ReadLine() => Console.ReadLine();
    }
    public sealed class ConsoleOutputWriter : IOWriter // skriver en rad från konsolen
    {
        public void WriteLine(string message) => Console.WriteLine($"{message:F2}");
    }
}
