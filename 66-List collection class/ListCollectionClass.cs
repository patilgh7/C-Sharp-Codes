using System;
using System.Collections.Generic;


namespace ListCollection
{
	public class CollectionDemo
	{
		public static void Main()
		{

			Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
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
                Salary = 3500
            };

         	
         	List<Customer> customerList = new List<Customer>(2);

         	customerList.Add(customer1);
         	customerList.Add(customer2);
         	customerList.Add(customer3);

         	Console.WriteLine("Retrieving single element (0th element)");
         	Customer cust = customerList[0];
         	Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);

         	Console.WriteLine("--------------------------------------");
         	Console.WriteLine("Retrieving elements using foreach loop");
         	foreach(Customer c in customerList)
         	{
         		Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
         	}

         	Console.WriteLine("--------------------------------------");
         	Console.WriteLine("Retrieving elements using for loop");

         	for(int i = 0; i < customerList.Count; i++)
         	{
         		Customer c = customerList[i];
         		Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
         	}

         	
         	

		}
	}


    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }


    }



}