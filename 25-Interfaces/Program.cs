using System;


interface ICustomer
{
	void Print();
}

interface I2
{
	void I2Method();
}


public class Customer : ICustomer, I2
{
	public void Print()
	{
		Console.WriteLine("Interface Print Method");
	}

	public void I2Method()
	{
		Console.WriteLine("I2 Method");
	}
}

public class Program
{
	public static void Main()
	{
		Customer C1 = new Customer();
		C1.Print();
	}
}