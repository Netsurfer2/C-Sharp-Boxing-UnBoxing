using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    /**************************** BOXING AND UNBOXING ********************************
     *Boxing means when you pass information from a value type to a reference type.  *
     *UnBoxing is when you pass a information from a reference type to a value type. *
     *********************************************************************************
    */
    class MyClass
    {
        public void MyMethod()
        {
            // Boxing (Value Type to Reference Type). The value is passed from the variable, then to the object.
            int Value = 1;
            Object Obj = Value;

            // UnBoxing (Reference Type to Value Type). The value is passed from the object to i.
            int i = (int)Obj;

            // Write out our value.
            Console.WriteLine("The value that I have passed from Boxing to UnBoxing is: {0}", i);

            // Pause the Console. 
            Console.ReadKey();

        }
    }
}
