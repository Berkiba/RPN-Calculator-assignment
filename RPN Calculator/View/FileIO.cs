using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.View
{
    public class FileIOReader : IOReader
    {
        private string[] _rader; // Save all lines from the file
        private int _index = 0; // A way to know which line we are at

        public FileIOReader(string filePath)
        {
            _rader = File.ReadAllLines(filePath); // Reads input.txt like a list of rows
        }

        public string? ReadLine() 
        {
            if (_index >= _rader.Length) // In case row index are over the number of rows in the file => null

                return null;


            string rad = _rader[_index]; // Otherwize go up an index and return the row
            _index++;
            return rad;
        }
    }

    public class FileIOWriter : IOWriter
    {
        private readonly string _filePath;

        public FileIOWriter(string filePath, bool overwrite = false)
        {
            _filePath = filePath;

            if (overwrite && File.Exists(_filePath))
            {
                File.Delete(_filePath); // Delete the file if it already exists
            }
        }

        public void WriteLine(string message) // This writes the lines in output.txt
        {
            File.AppendAllText(_filePath, message + System.Environment.NewLine);
        }


    }

}
