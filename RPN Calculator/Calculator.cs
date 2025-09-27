using Calculator.Controller;
using Calculator.Model;
using Calculator.View;
using System;

namespace Calculator
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            Logic logic = new Logic();

            IOReader reader;
            IOWriter writer;

            if (args.Length == 0)
            {
                // Interaktivt läge (via konsolen)
                reader = new ConsoleIO();
                writer = new ConsoleIO();
            }
            else if (args.Length == 2)
            {
                // Fil-baserat läge
                string inputFile = args[0];
                string outputFile = args[1];
                reader = new FileIO(inputFile);
                writer = new FileIO(outputFile, true);
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
