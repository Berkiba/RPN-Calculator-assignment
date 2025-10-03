using Calculator.Controller;
using Calculator.Model;
using Calculator.View;
using System;

namespace Calculator
{
    public class Calculator
    {

        // Main entry point
        static void Main(string[] args)
        {
            Logic logic = new Logic();

            IOReader reader;
            IOWriter writer;

            // Console state
            if (args.Length == 0)
            {
                reader = new ConsoleInputReader(); 
                writer = new ConsoleOutputWriter();
            }
            else if (args.Length == 2)
            {
                // File state
                string inputFile = args[0];
                string outputFile = args[1];
                reader = new FileIOReader(inputFile);
                writer = new FileIOWriter(outputFile, true);
            }
            // Syntax error state
            else
            {
                Console.WriteLine("Syntax: Calculator [source destination]");
                return;
            }
            // Create controller and run program
            CalculatorController controller = new CalculatorController(logic, reader, writer);
            controller.Run();


            // Runs the Input and Output files, overwrites the Output file if necessary
            CalculatorController.RunFile("input.txt", "output.txt", overwrite: true);
        }
    }
}
