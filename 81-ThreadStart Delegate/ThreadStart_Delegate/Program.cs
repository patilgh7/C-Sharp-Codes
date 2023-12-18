using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadStart_Delegate
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Thread T1 = new Thread(new ThreadStart(Number.PrintNumbers)); 

            // We can rewrite above same line using delegate() keyword

            //Thread T1 = new Thread(delegate () { Number.PrintNumbers(); });


            // We can rewrite same line using lambda expression
            Thread T1 = new Thread(() => { Number.PrintNumbers(); });

            T1.Start();
        }
    }

    class Number 
    {
        public static void PrintNumbers() 
        { 
            for (int i = 1; i < 10; i++) 
            { 
                Console.WriteLine(i);
            }
        }
    }
}
