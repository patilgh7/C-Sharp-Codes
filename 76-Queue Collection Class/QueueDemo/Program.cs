using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo
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

            Queue<Customer> queueCustomers = new Queue<Customer>();

            // To Add elements in queue we use Enqueue()
            queueCustomers.Enqueue(customer1);
            queueCustomers.Enqueue(customer2);
            queueCustomers.Enqueue(customer3);
            queueCustomers.Enqueue(customer4);
            queueCustomers.Enqueue(customer5);

            // A foreach loop iterates through the items in the queue,but will not remove from the queue.
            Console.WriteLine("Using ForEach Loop : ");
            foreach (Customer c in queueCustomers)
            {
                Console.WriteLine(c.ID + "-" + c.Name);
                Console.WriteLine("Total Items in the Queue = " + queueCustomers.Count);
            }

            Console.WriteLine("====================================================");

            // Peek() is to retrieve elements from queue without removing it.
            Console.WriteLine("Using Peek method : ");
            Customer cust1 = queueCustomers.Peek();
            Console.WriteLine(cust1.ID + "-" + cust1.Name);
            Console.WriteLine("Total Items in the Queue = " + queueCustomers.Count);

            // After creating another object using Peek method
            // Still it is giving same output of customer1 object data (101-Mark) 
            Console.WriteLine("After creating another object using Peek method : ");
            Customer cust2 = queueCustomers.Peek();
            Console.WriteLine(cust2.ID + "-" + cust2.Name);
            Console.WriteLine("Total Items in the Queue = " + queueCustomers.Count);
            Console.WriteLine("====================================================");


            // Dequeue() is to retrieve elements with removing it from queue.
            // Dequeue method is used to remove and return item at the beginning of the queue 
            Console.WriteLine("Using Dequeue method : ");
            Customer c1 = queueCustomers.Dequeue();
            Console.WriteLine(c1.ID +"-"+c1.Name);
            Console.WriteLine("Total Items in the Queue = "+queueCustomers.Count);

            Customer c2 = queueCustomers.Dequeue();
            Console.WriteLine(c2.ID + "-" + c2.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

            Customer c3 = queueCustomers.Dequeue();
            Console.WriteLine(c3.ID + "-" + c3.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

            Customer c4 = queueCustomers.Dequeue();
            Console.WriteLine(c4.ID + "-" + c4.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

            Customer c5 = queueCustomers.Dequeue();
            Console.WriteLine(c5.ID + "-" + c5.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

            Console.WriteLine("===================================================");

        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Gender { get; set; }
    }
}
