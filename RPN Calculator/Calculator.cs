using Calculator.Controller;
using Calculator.Model;
using Calculator.View;
using System;

namespace Calculator
{
    public class Calculator
    {

        //Note: Maybe change the return type of the token operations to float instead of double.
        static void Main(string[] args)
        {
            Logic logic = new Logic();

            IOReader reader;
            IOWriter writer;

            if (args.Length == 0)
            {
                reader = new ConsoleInputReader(); // ändrade dessa för det var mismatch här // zaid
                writer = new ConsoleOutputWriter();
            }
            else if (args.Length == 2)
            {
                // Fil läge
                string inputFile = args[0];
                string outputFile = args[1];
                reader = new FileIOReader(inputFile); // här också
                writer = new FileIOWriter(outputFile, true);
            }
            else
            {
                Console.WriteLine("Syntax: Calculator [source destination]");
                return;
            }

            CalculatorController controller = new CalculatorController(logic, reader, writer);
            controller.Run();
        }
    }

    }
