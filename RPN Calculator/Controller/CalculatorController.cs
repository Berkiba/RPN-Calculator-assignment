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
    {  // Jafar
        Logic logic;
        IOReader reader;
        IOWriter writer;

        public CalculatorController(Logic logic, IOReader reader, IOWriter writer)
        {
            this.logic = logic;
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            while (true)
            {
                string input = reader.ReadLine();

                if (input == "")
                {
                    writer.WriteLine("Program ended");
                    break;
                }

                try
                {
                    double result = logic.Calculate(input);
                    writer.WriteLine("Result: " + result);
                }
                catch (Exception e)
                {
                    writer.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}