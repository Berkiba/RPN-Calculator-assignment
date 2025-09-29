using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Calculator.View
{
    internal class ConsoleIO : IOReader, IOWriter
    {
        public string ReadLine()
        {
            Console.Write("Enter expression (empty = exit): ");
            return Console.ReadLine() ?? "";
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}

