using AssemblyOne;

/*
 
    internal int ID = 101; 
    we declare ID access modifier as 'internal'

    So basically we are here trying to access in this AssemblyTwo class library
    But we can not access that member because it is decalare as internal
 
 */


namespace AssemblyTwo
{
    public class AssemblyTwoClassI
    {
        public void Print()
        {
            AssemblyOneClassI A1 = new AssemblyOneClassI();

            // Here we don't have access for AssemblyOneClassI ID member
        }
    }


}