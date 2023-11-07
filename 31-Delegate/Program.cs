using System;

// delegate declaration is like method declaration

public delegate void HelloMethodDelegate();

public class Program
{

	public static void Main()
	{
		/* A delegate is type safe function pointer

		   If you want to call any method using delegate you have to create instance of delegate like any class instance we created.

		   And pass the method name which you want call in that delegate constructor

		*/


		// Delegate object created

		HelloMethodDelegate del = new HelloMethodDelegate(Hello);

		// calling method using object and passing message to that object because we have pass string while delegate declaration
		del();

	}


	public static void Hello()
	{
		Console.WriteLine("Hi from delegate");
	}
}