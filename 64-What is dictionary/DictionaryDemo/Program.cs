using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
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


            Dictionary<int,Customer> dictionaryCustomers = new Dictionary<int,Customer>();

            dictionaryCustomers.Add(customer1.ID, customer1);

            dictionaryCustomers.Add(customer2.ID, customer2);

            dictionaryCustomers.Add(customer3.ID, customer3);

            Customer customer119 = dictionaryCustomers[119];

            //Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer119.ID, customer119.Name, customer119.Salary);


            // all data printed
            Console.WriteLine("All data printed");
            foreach (KeyValuePair<int, Customer> customerKeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("Key = {0} ", customerKeyValuePair.Key);
                Customer cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
                Console.WriteLine("---------------------------------------------------------");


            }

            // if you want print only keys
            Console.WriteLine("Print only keys");
            foreach (int key in dictionaryCustomers.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("---------------------------------------------------------");


            // if you want print only values
            Console.WriteLine("Print only values");
            foreach (Customer cust in dictionaryCustomers.Values)
            {

                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
                Console.WriteLine("---------------------------------------------------------");
            }

            // if you want check suppose 135 key is present or not using ContainsKey method
            if (dictionaryCustomers.ContainsKey(135))
            {
                Console.WriteLine("Key 135 is present");
            }
            else
            {
                Console.WriteLine("Key 135 is not present in this code");
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
