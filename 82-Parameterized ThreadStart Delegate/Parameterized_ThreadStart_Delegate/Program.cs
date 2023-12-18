using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
 *  Please note: 
 *  
 *  Using ParameterizedThreadStart delegate and Thread.Start(Object) method to pass data to the Thread function is not type safe. 
 *  As they operate on object datatype and any type of data can be passed.
 *  If you try to change the data type of the target parameter of PrintNumbers() function from object to int,
 *  a compiler error will be raised as the signature of PrintNumbers() function does not match 
 *  with the signature of ParameterizedThreadStart delegate.
 *   
 */

namespace Parameterized_ThreadStart_Delegate
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the target number");
            object target = Console.ReadLine();
            Number number = new Number();
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(number.PrintNumbers);
            Thread T1 = new Thread(parameterizedThreadStart);
            T1.Start(target);
        }
    }

    class Number
    {
        public void PrintNumbers(object target)
        {
            int number = 0;
            int.TryParse(target.ToString(), out number);
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
