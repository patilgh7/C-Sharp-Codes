using System;
using System.Reflection;

namespace LateBindingUsingReflection
{
    public class MainClass
    {
       private static void Main()
       {
            // Late Binding Or At Run time object is created

            // Below code is for late binding

            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            Type customerType = executingAssembly.GetType("LateBindingUsingReflection.Customer");

            // Activator.CreateInstance(customerType) will create instance
            object customerInstance = Activator.CreateInstance(customerType);

            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");

            // here always check the parameters datatype string or int ...in our case GetFullName() method has 2 string parameters
            string[] parameters = new string[2];
            parameters[0] = "Pragim";
            parameters[1] = "Tech";

            // string is inherited from System.Object so thats why we use directly string[] parameters as second parameter of Invoke
            // method

            // And explicitly cast in string because its return type is object
            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);

            Console.WriteLine("Full Name = {0} ", fullName);





            /*
                Early Binding Or At Compile time object is created

                Below code is for early binding 

                Customer C1 = new Customer();
                string fullName = C1.GetFullName("Pragim", "Tech");
                Console.WriteLine("Full Name = {0} ", fullName);
             
             */


        }
    }

    public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }



}

