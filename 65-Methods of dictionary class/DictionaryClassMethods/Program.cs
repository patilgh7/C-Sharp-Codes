using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryClassMethods
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


            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();

            dictionaryCustomers.Add(customer1.ID, customer1);

            dictionaryCustomers.Add(customer2.ID, customer2);

            dictionaryCustomers.Add(customer3.ID, customer3);


            // Using TryGetValue method

            Customer cust;

            if (dictionaryCustomers.TryGetValue(102, out cust))
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary ={2} ", cust.ID, cust.Name, cust.Salary);
                    
            }
            else
            {
                Console.WriteLine("The key is not found");
            }

            // if you want to find total number element present in dictionary then use Count property or Count method

            Console.WriteLine("Total items in dictionary using Count property = {0} ", dictionaryCustomers.Count);
            Console.WriteLine("Total items in dictionary using Count method = {0} ", dictionaryCustomers.Count());

            // Use Count method with predicate
            // Predicate functions are functions that return a single TRUE or FALSE .
            // You use predicate functions to check if your input meets some condition.

            // Here we are checking is anyones salary is greater than 4000 in this dictionary
            Console.WriteLine("Total items in dictionary = {0} ", dictionaryCustomers.Count(keyValuePair => keyValuePair.Value.Salary > 4000));


            // If you want remove anyone key from dictionary use Remove method
            //dictionaryCustomers.Remove(101);

            // If you want remove all keys from dictionary use Clear method
            //dictionaryCustomers.Clear();

            Console.WriteLine("----------------------------------------");

            // Convert Array into Dictionary using ToDictionary

            Console.WriteLine("Convert Array into Dictionary using ToDictionary");

            Customer[] customers = new Customer[3];
            customers[0] = customer1;
            customers[1] = customer2;
            customers[2] = customer3;

            //                                                       Key = cstmer.ID   Value = cstmer object
            //                                                           ||                  || 
            Dictionary<int, Customer> dict = customers.ToDictionary(cstmer => cstmer.ID, cstmer => cstmer);


            foreach (KeyValuePair<int, Customer> kvp in dict)
            {
                Console.WriteLine("Key = {0} ",kvp.Key);
                Customer c = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2} ", c.ID, c.Name, c.Salary);
                Console.WriteLine("----------------------------------------");
            }

            Console.WriteLine("----------------------------------------");



            // Convert List into Dictionary using ToDictionary

            Console.WriteLine("Convert List into Dictionary using ToDictionary");

            List<Customer> list = new List<Customer>();
            list.Add(customer1);
            list.Add(customer2);
            list.Add(customer3);

            Dictionary<int, Customer> dict2 = list.ToDictionary(cstmer => cstmer.ID, cstmer => cstmer);


            foreach (KeyValuePair<int, Customer> kvp in dict2)
            {
                Console.WriteLine("Key = {0} ", kvp.Key);
                Customer c2 = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2} ", c2.ID, c2.Name, c2.Salary);
                Console.WriteLine("----------------------------------------");
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
