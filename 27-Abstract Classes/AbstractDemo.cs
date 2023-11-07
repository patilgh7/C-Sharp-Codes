using System;


public abstract class Customer
{
	public abstract void Print();
}

public class Program : Customer
{

	public override void Print()
	{
		Console.WriteLine("Print Method");
	}


	public static void Main()
	{
		Program P = new Program();

		P.Print();
	}
}