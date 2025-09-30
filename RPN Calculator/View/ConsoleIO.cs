using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Calculator.View
{
    public sealed class ConsoleInputReader : IOReader // Reads a line from the console
    {
        public string? ReadLine() => Console.ReadLine();
    }
    public sealed class ConsoleOutputWriter : IOWriter // Writes a line to the console
    {
        public void WriteLine(string message) => Console.WriteLine($"{message:F2}");
    }
}
