using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_A_List
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("===========================================");
            Console.WriteLine("Numbers Operations");

            List<int> numbers = new List<int>() { 1,8,7,5,2,3,4,9,6 };

            Console.WriteLine("Numbers Before Sorting");

            foreach (int number in numbers)
            {
                Console.Write(number+" ");
            }

            Console.WriteLine();


            numbers.Sort();

            Console.WriteLine("Numbers After Sorting");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.Write("\n");

            numbers.Reverse(); 
            
            Console.WriteLine("Numbers in descending order");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.Write("\n");
            Console.WriteLine("===========================================");

            Console.WriteLine("Alphabets Operations");

            List<string> alphabets = new List<string>() { "B", "F", "D", "E", "A", "C" };

            Console.WriteLine("Alphabets Before Sorting");

            foreach (string alphabet in alphabets)
            {
                Console.Write(alphabet + " ");
            }

            Console.WriteLine();

            alphabets.Sort();

            Console.WriteLine("Alphabets After Sorting");

            foreach (string alphabet in alphabets)
            {
                Console.Write(alphabet + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Alphabets in descending order");

            alphabets.Reverse();

            foreach (string alphabet in alphabets)
            {
                Console.Write(alphabet + " ");
            }

            Console.WriteLine();

            Console.WriteLine("===========================================");
        }
    }
}
