using Calculator.Model;
using Calculator.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;


namespace Calculator.Controller
{
    internal class CalculatorController
    {  //Composition
        Logic logic;
        IOReader reader;
        IOWriter writer;


        public CalculatorController(Logic logic, IOReader reader, IOWriter writer)
        {
            // Contructors with dependencies
            this.logic = logic;
            this.reader = reader;
            this.writer = writer;
        }
        public static void RunFile(string inputPath, string outputPath, bool overwrite = false, Logic? logic = null)
        {

            // Reads and writes the input and output files
            var reader = new FileIOReader(inputPath);
            var writer = new FileIOWriter(outputPath, overwrite);
            logic ??= new Logic();

            var controller = new CalculatorController(logic, reader, writer);
            controller.Run();
        }


        public void Run()
        {
            while (true)
            {
                string input = reader.ReadLine();
                // End program if input is empty
                if (input == "")
                {
                    writer.WriteLine("Program ended");
                    break;
                }
                // Process input and handle exceptions
                try
                {
                    double result = logic.Calculate(input);
                    writer.WriteLine($"{result:F2}");
                }
        
                catch (Exception e)
                {
                    // Catch all exceptions and print error message
                    writer.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}