using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Stack is LIFO => Last in first out
 */

namespace StackDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Gender = "Male"
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Gender = "Female"
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "John",
                Gender = "Male"
            };

            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "Ken",
                Gender = "Male"
            };

            Customer customer5 = new Customer()
            {
                ID = 105,
                Name = "Valarie",
                Gender = "Female"
            };

            Stack<Customer> stackCustomers = new Stack<Customer>();

            stackCustomers.Push(customer1);
            stackCustomers.Push(customer2);
            stackCustomers.Push(customer3);
            stackCustomers.Push(customer4);
            stackCustomers.Push(customer5);



            Console.WriteLine("Using ForEach Loop : ");
            foreach (Customer c in stackCustomers)
            {
                Console.WriteLine(c.ID + "-" + c.Name);
                Console.WriteLine("Total Items in the Stack = " + stackCustomers.Count);
            }

            Console.WriteLine("====================================================");


            // Peek() is to retrieve elements from stack without removing it.
            Console.WriteLine("Using Peek method : ");
            Customer cust1 = stackCustomers.Peek();
            Console.WriteLine(cust1.ID + "-" + cust1.Name);
            Console.WriteLine("Total Items in the Stack = " + stackCustomers.Count);

            // After creating another object using Peek method
            // Still it is giving same output of customer5 object data (105-Valarie) 
            Console.WriteLine("After creating another object using Peek method : ");
            Customer cust2 = stackCustomers.Peek();
            Console.WriteLine(cust2.ID + "-" + cust2.Name);
            Console.WriteLine("Total Items in the Stack = " + stackCustomers.Count);
            Console.WriteLine("====================================================");


            Console.WriteLine("Using Pop method : ");
            Customer c1 = stackCustomers.Pop();
            Console.WriteLine(c1.ID + " - " + c1.Name);
            Console.WriteLine("Items left in the Stack = " + stackCustomers.Count);

            Customer c2 = stackCustomers.Pop();
            Console.WriteLine(c2.ID + "-" + c2.Name);
            Console.WriteLine("Items left in the Stack = " + stackCustomers.Count);

            Customer c3 = stackCustomers.Pop();
            Console.WriteLine(c3.ID + "-" + c3.Name);
            Console.WriteLine("Items left in the Stack = " + stackCustomers.Count);

            Customer c4 = stackCustomers.Pop();
            Console.WriteLine(c4.ID + "-" + c4.Name);
            Console.WriteLine("Items left in the Stack = " + stackCustomers.Count);

            Customer c5 = stackCustomers.Pop();
            Console.WriteLine(c5.ID + "-" + c5.Name);
            Console.WriteLine("Items left in the Stack = " + stackCustomers.Count);

            Console.WriteLine("====================================================");

        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Gender { get; set; }
    }
}
