using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.View
{
    internal class FileIO : IOReader, IOWriter
    {
        private StreamReader? reader;
        private StreamWriter? writer;

        // Konstruktor för läsning
        public FileIO(string inputFile)
        {
            reader = new StreamReader(inputFile);
        }

        // Konstruktor för skrivning
        public FileIO(string outputFile, bool writeMode)
        {
            writer = new StreamWriter(outputFile);
        }

        public string ReadLine()
        {
            if (reader == null || reader.EndOfStream) return "";
            return reader.ReadLine() ?? "";
        }

        public void WriteLine(string message)
        {
            if (writer != null)
            {
                writer.WriteLine(message);
                writer.Flush();
            }
        }
    }
}