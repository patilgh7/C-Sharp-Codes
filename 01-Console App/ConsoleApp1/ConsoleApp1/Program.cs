using System;


 class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("Please Enter Your First Name : ");

        string FirstName = Console.ReadLine();

        Console.WriteLine("Please Enter Your Last Name : ");

        string LastName = Console.ReadLine();


        //Console.WriteLine("Hello " + UserName);

        // Using PlaceHolder

        Console.WriteLine("Hello {0} {1} ", FirstName,LastName);


    }
}

