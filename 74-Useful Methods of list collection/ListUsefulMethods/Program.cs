using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListUsefulMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000
            };

            Customer customer2 = new Customer()
            {
                ID = 103,
                Name = "John",
                Salary = 7000
            };

            Customer customer3  = new Customer()
            {
                ID = 102,
                Name = "Ken",
                Salary = 5500
            };

            List<Customer> listCustomers = new List<Customer>();

            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            // TrueForAll() => this method iterate like foreach loop and return boolean result(True or False)
            bool _salary = listCustomers.TrueForAll(x => x.Salary > 3000);
            Console.WriteLine("Are all salaries greater than 3000 = " + _salary);

            // AsReadOnly() => it gives read only access 
            ReadOnlyCollection<Customer> readOnlyCustomers = listCustomers.AsReadOnly();
            Console.WriteLine("Items = "+readOnlyCustomers.Count);


            // TrimExcess() => List<Customer>(100) we intially gives capacity to 100 check output after using this method
            // This method can be used to minimize a collection memory
            List<Customer> list2 = new List<Customer>(100);

            list2.Add(customer1);
            list2.Add(customer2);
            list2.Add(customer3);

            Console.WriteLine("Capacity before trimming = "+list2.Capacity);

            list2.TrimExcess();

            Console.WriteLine("Capacity after trimming = " + list2.Capacity);
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }


    }
}
