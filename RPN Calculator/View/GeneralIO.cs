using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.View
{
    public interface IOReader // Reads a row text
    {
        string? ReadLine();
    }

    public interface IOWriter // Writes a row text
    {
        void WriteLine(string message);
    }
}// These are used only as helper functions for ConsoleIO and FileIO

