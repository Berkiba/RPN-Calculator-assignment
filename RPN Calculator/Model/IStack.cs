using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    public interface IStack<T>
    {
        void Push(T item);   // Lägger till ett element på stacken
        T Pop();             // Tar bort och hämtar det översta elementet
        bool IsEmpty();      // Kollar om stacken är tom
    }
}
