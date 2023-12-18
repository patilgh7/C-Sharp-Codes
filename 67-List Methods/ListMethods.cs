using System;
using System.Collections.Generic;


namespace ListMethods
{
	public class CollectionDemo
	{
		public static void Main()
		{

			Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000
            };

            Customer customer2 = new Customer()
            {
                ID = 110,
                Name = "Pam",
                Salary = 6500
            };

            Customer customer3 = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 5500
            };

         	
         	List<Customer> listCustomers = new List<Customer>();

         	listCustomers.Add(customer1);
         	listCustomers.Add(customer2);
         	listCustomers.Add(customer3);

            Console.WriteLine("Contains method");

            if(listCustomers.Contains(customer3))
            {
                Console.WriteLine("Customer3 object exists in the list");

            }
            else
            {
                Console.WriteLine("Customer3 object does not exists in the list");
            }

            Console.WriteLine("--------------------------------------");
         	Console.WriteLine("Exists method");
            if(listCustomers.Exists(cust => cust.Name.StartsWith("P")))
            {
                Console.WriteLine("Name starts with 'P' is present");

            }
            else
            {
                Console.WriteLine("Name starts with 'P' is not present");
            }


            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Find method");
            // Find method only return first matching item from list 
            // so that why it shows Pam name ...but in our code there are 2 members salary above 5000 Pam and John
            Customer c = listCustomers.Find(cust => cust.Salary > 5000);

            Console.WriteLine("ID = {0} , Name = {1}, Salary = {2} ", c.ID, c.Name, c.Salary);


            Console.WriteLine("--------------------------------------");
            Console.WriteLine("FindLast method");
            // FindLast method only return last matching item from list
            // so that why it shows John name 

            Customer c2 = listCustomers.FindLast(cust => cust.Salary > 5000);

            Console.WriteLine("ID = {0} , Name = {1}, Salary = {2} ", c2.ID, c2.Name, c2.Salary);


            Console.WriteLine("--------------------------------------");
            Console.WriteLine("FindAll method");
            // FindAll method return all items from list
            
            List<Customer> list = listCustomers.FindAll(cust => cust.Salary > 5000);

            foreach(Customer c3 in list)
            {
                Console.WriteLine("ID = {0} , Name = {1}, Salary = {2} ", c3.ID, c3.Name, c3.Salary);
            }

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("FindIndex method");

            // FindIndex method return index of given object
            // FindIndex method only return first matching object from list
            int index  = listCustomers.FindIndex(cust => cust.Salary > 5000);
            Console.WriteLine("Index = "+index);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("FindLastIndex method");

            // FindLastIndex method return last index of given object
            // FindLastIndex method only return last matching object from list
            int lastIndex  = listCustomers.FindLastIndex(cust => cust.Salary > 5000);
            Console.WriteLine("Last Index = "+lastIndex);
		}
	}


    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }


    }



}