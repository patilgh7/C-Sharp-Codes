using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SamplePartialClass SPC = new SamplePartialClass();

            SPC.PublicMethod();
        }
    }
}
