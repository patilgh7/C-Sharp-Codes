using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClass
    {
        public void Test()
        {
            AssemblyOneClass assemblyOneClass = new AssemblyOneClass(); 
            assemblyOneClass.Print();
        }
    }
}