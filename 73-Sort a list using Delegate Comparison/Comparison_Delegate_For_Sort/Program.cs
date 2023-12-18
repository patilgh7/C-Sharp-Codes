using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 3 Approaches for doing Delegate Comparison
 * 
 * 1st Approach :  Here we have compared ID's
 *      // create private method to call from delegate constructor
        private static int CompareCustomer(Customer x, Customer y)
        {
            return x.ID.CompareTo(y.ID);
        }

         // created delegate instance and invoke CompareCustomer method
        Comparison<Customer> customerComparer = new Comparison<Customer>(CompareCustomer);
 * 
 * 2nd Approach Using Delegate Keyword: Here we have compared Names
 * 
 *   listCustomers.Sort(delegate(Customer c1, Customer c2) { return c1.Name.CompareTo(c2.Name); });
 *   
 *   
 * 3rd Approach Using Lambda Expression: Here we have compared Salaries
 * 
 * 
 *   listCustomers.Sort((cust1, cust2) => cust1.Salary.CompareTo(cust2.Salary));
 * 
 */

namespace Comparison_Delegate_For_Sort
{
    public class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 4000
            };

            Customer customer2 = new Customer()
            {
                ID = 101,
                Name = "Rob",
                Salary = 7000
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Mark",
                Salary = 5500
            };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

          
            Console.WriteLine("Original data before all sortings");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2} ",c.ID,c.Name,c.Salary);
            }


            // created delegate instance and invoke CompareCustomer method
            Comparison<Customer> customerComparer = new Comparison<Customer>(CompareCustomer);

            Console.WriteLine("============================");
            Console.WriteLine("1st Approach");
            Console.WriteLine("Before Sorting");

            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.ID);
            }

            listCustomers.Sort(customerComparer);

            Console.WriteLine("============================");
            Console.WriteLine("After Sorting");

            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.ID);
            }


            Console.WriteLine("==============================================================================");
            Console.WriteLine("2nd Approach Using Delegate Keyword");

            Console.WriteLine("Before Sorting");

            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Name);
            }

            Console.WriteLine("============================");
            Console.WriteLine("After Sorting");

            // Using Delegate Keyword
            listCustomers.Sort(delegate(Customer c1, Customer c2) { return c1.Name.CompareTo(c2.Name); });

            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Name);
            }


            Console.WriteLine("=============================================================================");
            Console.WriteLine("3rd Approach Using Lambda Expression");

            Console.WriteLine("Before Sorting");

            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Salary);
            }

            Console.WriteLine("============================");
            Console.WriteLine("After Sorting");

            // Using Lambda Expression
            listCustomers.Sort((cust1, cust2) => cust1.Salary.CompareTo(cust2.Salary));

            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Salary);
            }

        }

        // create private method to call from delegate constructor
        private static int CompareCustomer(Customer x, Customer y)
        {
            return x.ID.CompareTo(y.ID);
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }



}
