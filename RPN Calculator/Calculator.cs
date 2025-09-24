using Calculator.Model;

namespace Calculator
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            RpnStack<int> stack = new RpnStack<int>();

            stack.Push(5);
            stack.Push(10);


            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.IsEmpty());
        }
    }
}
