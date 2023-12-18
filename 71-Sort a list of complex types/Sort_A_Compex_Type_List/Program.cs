using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Note : When you check salary comparison uncomment the respective code
 */

/*
    IComparable<Customer> interace we have used to compare the name and salary.
    So we have used CompareTo method for comparison from IComparable interface
    Check below code to understand. 

*/    

namespace Sort_A_Compex_Type_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID= 101,
                Name = "Mark",
                Salary = 4000
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };

            Customer customer3 = new Customer()
            {
                ID = 101,
                Name = "Rob",
                Salary = 5500
            };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            //Console.WriteLine("Before Sorting By Customer Salary");
            //foreach (Customer c in listCustomers)
            //{
            //    Console.WriteLine(c.Salary);
            //}

            //listCustomers.Sort();

            //Console.WriteLine("After Sorting By Customer Salary");

            //foreach (Customer c in listCustomers)
            //{
            //    Console.WriteLine(c.Salary);
            //}

            //Console.WriteLine("Descending order");

            //listCustomers.Reverse();

            //foreach (Customer c in listCustomers)
            //{
            //    Console.WriteLine(c.Salary);
            //}


            Console.WriteLine("=====================================");

            Console.WriteLine("Before Sorting By Customer Name");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Name);
            }

            listCustomers.Sort();

            Console.WriteLine("After Sorting By Customer Name");

            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Name);
            }
        }
    }

    public class Customer : IComparable<Customer> 
    {   
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }


        /*
            - this.Salary > other.Salary  then return 1 
            - this.Salary < other.Salary  then return -1
            - this.Salary == other.Salary  then return 0   (When equal then 0)
            

            public int CompareTo(Customer other)
            {
                if (this.Salary > other.Salary)
                    return 1;
                else if (this.Salary < other.Salary)
                    return -1;
                else
                    return 0;
            }

            use this code or below code
         
         */
        

        //public int CompareTo(Customer other)
        //{
        //    return this.Salary.CompareTo(other.Salary);
                
        //}


        public int CompareTo(Customer other)
        {
            return this.Name.CompareTo(other.Name);

        }
    }
}
