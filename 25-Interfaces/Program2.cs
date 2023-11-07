using System;



interface ICustomer1
{
	void Print1();
}

interface ICustomer2 : ICustomer1
{
	void Print2();
}

public class Customer : ICustomer2
{
	public void Print1()
	{
		Console.WriteLine("Print 1");
	}

	public void Print2()
	{
		Console.WriteLine("Print 2");
	}
}

public class Program2
{
	public static void Main()
	{
		Customer C1 = new Customer();

		C1.Print1();
		C1.Print2();

		Console.WriteLine("=======================");

		// You can create reference variable of interface that is pointing to class object
		// that means Parent class or parent interface reference variable can pointing towards child class object.

		ICustomer1 ICust = new Customer();
		ICust.Print1();

	}
}

