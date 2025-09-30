using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    // A basic stack that uses a list in the background
    public class RpnStack<T> : IStack<T>
    {
        private List<T> items;   // Here are the items stored

        public RpnStack()
        {
            items = new List<T>();
        }

        public void Push(T item)
        {
            items.Add(item);                     // Add item to the end of the list
        }

        public T Pop()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            // Getting the last item
            int lastIndex = items.Count - 1;
            T value = items[lastIndex];

            // Take it out from the list
            items.RemoveAt(lastIndex);

            return value;
        }

        // Check if stack is empty
        public bool IsEmpty()
        {
            return items.Count == 0;
        }
        // Clear the stack
        public void Clear()
        {
            items.Clear();
        }
    }
}



