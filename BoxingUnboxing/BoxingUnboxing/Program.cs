using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new object as "MyClass" using the new keyword and variable name to access the Class.
            MyClass MyObjectName = new MyClass();

            // Call "MyMethod" by including the Variable name of the Object.
            MyObjectName.MyMethod();
        }
    }
}
