
/*


	Reflection is the ability of inspecting an assemblies' metadata at runtime. 
	It is used to find all types in an assembly and/or dynamically invoke methods in an assembly.

	Uses of reflection:

	1. When you drag and drop a button on a win forms or an asp.net application. 
	The properties window uses reflection to show all the properties of the Button class. So, reflection is extensively used by IDE or a UI designers.

	2. Late binding can be achieved by using reflection. 
	You can use reflection to dynamically create an instance of a type, about which we don't have any information at compile time. 
	So, reflection enables you to use code that is not available at compile time.

	3. Consider an example where we have two alternate implementations of an interface. 
	You want to allow the user to pick one or the other using a config file. 
	With reflection, you can simply read the name of the class whose implementation you want to use from the config file,
	and instantiate an instance of that class.This is another example for late binding using reflection.



*/

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
