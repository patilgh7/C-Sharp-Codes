using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
 * To pass data to the Thread function in a type safe manner, 
 * encapsulate the thread function and the data it needs in a helper class and use the ThreadStart delegate to execute the thread function.
 * 
 
 */

namespace Thread_function_in_type_safe_manner
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the target number");

            int target = Convert.ToInt32(Console.ReadLine());   

            Number number = new Number(target);
            Thread T1 = new Thread(new ThreadStart(number.PrintNumbers));   
            T1.Start();
        }
    }

    class Number
    {
        private int _target;
        public Number(int target)
        {
            this._target = target;
        }

        public void PrintNumbers()
        {
            for(int i = 1; i <= _target; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
