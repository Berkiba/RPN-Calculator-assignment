using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.View
{
    public interface IOReader // läser en rad text
    {
        string? ReadLine();
    }

    public interface IOWriter // skriver en rad text
    {
        void WriteLine(string message);
    }
} // dessa används egentligen bara som hjälpfunktioner till ConsoleIO och FileIO

