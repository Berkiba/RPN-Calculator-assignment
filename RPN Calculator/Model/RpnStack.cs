using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{ 
                                        // En enkel stack som använder en lista i bakgrunden
        public class RpnStack<T> : IStack<T>
        {
            private List<T> items;   // Här sparar vi sakerna

            public RpnStack()
            {
                items = new List<T>();
            }

            public void Push(T item)
            {
                items.Add(item);                     // Lägg till längst bak i listan
            }

            public T Pop()
            {
                if (items.Count == 0)
                {
                    throw new InvalidOperationException("Stack is empty.");
                }

                                                 // Hämtar sista elementet
                int lastIndex = items.Count - 1;
                T value = items[lastIndex];

                                                // Tar bort det från listan
                items.RemoveAt(lastIndex);

                return value;
            }

            public bool IsEmpty()
            {
                return items.Count == 0;
            }
        }
    }



