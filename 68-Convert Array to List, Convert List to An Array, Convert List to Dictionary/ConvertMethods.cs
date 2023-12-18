using System;
using System.Collections.Generic;
using System.Linq; 


namespace ListMethods
{
	public class ConvertMethods
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


            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Convert Array to List");
         	
         	Customer[] customerArray = new Customer[3];

            customerArray[0] = customer1;
            customerArray[1] = customer2;
            customerArray[2] = customer3;



            List<Customer> listCustomers = customerArray.ToList();

            foreach(Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0} , Name = {1}, Salary = {2} ", c.ID, c.Name, c.Salary);
            }
           
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Convert List to Array");

            List<Customer> custList = new List<Customer>();
            custList.Add(customer1);
            custList.Add(customer2);
            custList.Add(customer3);

            Customer[] custArray = custList.ToArray();

            foreach(Customer c in custArray)
            {
                Console.WriteLine("ID = {0} , Name = {1}, Salary = {2} ", c.ID, c.Name, c.Salary); 
            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Convert List to Dictionary");

            List<Customer> custList2 = new List<Customer>();
            custList2.Add(customer1);
            custList2.Add(customer2);
            custList2.Add(customer3);

            Dictionary<int, Customer> dictionary = custList2.ToDictionary(x => x.ID);

            // ToDictionary(x => x.ID)  ==> x.ID is Key here we don't mention value because its not mandetory
            // if you want to mention value then you can mention => ToDictionary(x => x.ID, cust => cust);

            foreach(KeyValuePair<int, Customer> kvp in dictionary)
            {
                Console.WriteLine("Key = "+kvp.Key);
                Customer c = kvp.Value;
                Console.WriteLine("ID = {0} , Name = {1}, Salary = {2} ", c.ID, c.Name, c.Salary); 
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