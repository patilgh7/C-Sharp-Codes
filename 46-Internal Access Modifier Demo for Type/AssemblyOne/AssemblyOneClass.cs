using System;

namespace AssemblyOne
{

    //When we use internal access modifier to class it simply means it is only available within wherever it is defined.If you trying to access that type
    //outside of that somewhere it will give compiler error.
    internal class AssemblyOneClass
    {

        public void Print()
        {
            Console.WriteLine("Hello");
        }

    }
}