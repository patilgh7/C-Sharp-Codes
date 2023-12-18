using System;
using System.Reflection;

namespace Reflection_48
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            /*
                Type class gives method GetType this is basically used for if you want to know
                information about some class and what fields are there and what properties are present
                in that class in that case we use reflection concept.

                For that we use  T.GetProperties() this method so it is present in System.Reflection
             
             */



            //Type T = Type.GetType("Reflection_48.Customer");

            //Customer customer = new Customer();
            //Type T = customer.GetType();

            // 1) Type.GetType("Reflection_48.Customer"); instead of this we can use =>
            // 2) Customer customer = new Customer();   Type T = customer.GetType();
            // 3) typeof(Customer);
            // It gives same result.

            Type T = typeof(Customer);
           
            Console.WriteLine("Full Name  = {0} ", T.FullName);
            Console.WriteLine("Just the Name  = {0} ", T.Name);
            Console.WriteLine("Just the Namespace  = {0} ", T.Namespace);
            Console.WriteLine();



            Console.WriteLine("Properties in Customer Class : ");

            PropertyInfo[] properties = T.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name+ " "+property.Name);

            }

            Console.WriteLine();

            Console.WriteLine("Methods in Customer Class : ");

            MethodInfo[] methods = T.GetMethods();
            
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name+ " "+method.Name);
              
            }


            Console.WriteLine();

            Console.WriteLine("Constructors in Customer Class : ");

            ConstructorInfo[] constructors = T.GetConstructors();

            foreach (ConstructorInfo constructor in constructors)
            {
                // constructor.ToString() gives full constructor details
                Console.WriteLine(constructor.ToString());
            }



            Console.WriteLine();

            Console.WriteLine("Members in Customer Class : ");

            MemberInfo[] members = T.GetMembers();

            foreach (MemberInfo member in members)
            {
                Console.WriteLine(member.Name+ " "+member.MemberType);  
            }


        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer (int ID, string Name)
        {
            this.Id = ID;
            this.Name = Name;
   
        } 
        
        public Customer ()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }

        public void PrintID()
        {
            Console.WriteLine("ID = {0} ", this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name = {0} ", this.Name);
        }
    }
}
