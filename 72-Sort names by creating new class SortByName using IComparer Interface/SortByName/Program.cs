using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * If you prefer not to use the Sort functionality provided by class 
 * then you can provide your own by implementing IComparer interface
 * If you want compare Customer based on their names
 * In that case we craete our own custom class
 * We have created SortByName class to compare Customer class names.
 * IComparer<Customer> interface have compare method that method compare our names
 * Pass an instance of the class that implements IComparer interface as an argument to sort method 
 * 
 * Simply When you want to use own sort logic then use IComparer interface.
 
 */

namespace SortByName
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Pam",
                Salary = 4000
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Rob",
                Salary = 7000
            };

            Customer customer3 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5500
            };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            Console.WriteLine("Before Sorting ");

            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Name);
            }

            Console.WriteLine("=========================");

            // creating an instance of the class that implements IComparer interface as an argument to sort method
            SortByName sortByName = new SortByName();

            listCustomers.Sort(sortByName);

            Console.WriteLine("After Sorting By Name ");

            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Name);
            }


        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }

    // Implementing Class 
    public class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    } 
  

}
