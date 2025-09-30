using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.View
{
    public class FileIOReader : IOReader
    {
        private string[] _rader; // spara alla rader
        private int _index = 0; //något sätt att veta vilken rad man är på

        public FileIOReader(string filePath)
        {
            _rader = File.ReadAllLines(filePath); // läser in input.txt som en lista av rader
        }

        public string? ReadLine() 
        {
            if (_index >= _rader.Length) // ifall rad index är över antal rader i filen => null
                return null;


            string rad = _rader[_index]; // annars så går index upp och returnerar nästa rad
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
                File.Delete(_filePath); // tar bort filen om den redan finns,kanske blir error?
            }
        }

        public void WriteLine(string message)
        {
            File.AppendAllText(_filePath, message + "\n"); // nu borde det funka att skriva till filen
        }


    }

}
