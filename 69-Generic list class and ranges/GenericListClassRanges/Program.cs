using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListClassRanges
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000,
                Type = "RetailCustomer"
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000,
                Type = "RetailCustomer"
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Rob",
                Salary = 5500,
                Type = "RetailCustomer"
            };

            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "John",
                Salary = 6500,
                Type = "CorporateCustomer"
            };

            Customer customer5 = new Customer()
            {
                ID = 105,
                Name = "Sam",
                Salary = 3500,
                Type = "CorporateCustomer"
            };


            // All Range methods are operate on lists

            List<Customer> listCustomers = new List<Customer>();

            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            List<Customer> listCorporateCustomers = new List<Customer>();

            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("AddRange()");

            // AddRange() allows you to another list of items to the end list
            // Whereas Add() allows you to add one item at a time
            listCustomers.AddRange(listCorporateCustomers);

            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",c.ID, c.Name, c.Salary, c.Type);
            }

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("GetRange()");
            // GetRange()
            List<Customer> customers = listCustomers.GetRange(3, 2);

            foreach (Customer c in customers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
            }

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("InsertRange()");

            // InsertRange()

            Customer customer6 = new Customer()
            {
                ID = 106,
                Name = "Ron",
                Salary = 8500,
                Type = "CorporateCustomer"
            };

            Customer customer7 = new Customer()
            {
                ID = 107,
                Name = "Nikhil",
                Salary = 2500,
                Type = "CorporateCustomer"
            };

            List<Customer> listCorporateCustomers2 = new List<Customer>();

            listCorporateCustomers2.Add(customer6);
            listCorporateCustomers2.Add(customer7);

            listCustomers.InsertRange(5, listCorporateCustomers2);

            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
            }

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("RemoveAll() ==> All Corporate Customer Removed");

            // RemoveAll()

            listCustomers.RemoveAll(x => x.Type == "CorporateCustomer");

            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
            }

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("RemoveRange() ==> 2 Retail Customer Removed");

            listCustomers.RemoveRange(0, 2);

            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
            }


        }
    }


    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public string Type { get; set; }


    }

}
