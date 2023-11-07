using System;

interface I1
{
	void InterfaceMethod();
}

interface I2
{
	void InterfaceMethod();
}


public class Program : I1, I2
{
	void I1.InterfaceMethod()
	{
		Console.WriteLine("I1 Interface Method");
	}

	void I2.InterfaceMethod()
	{
		Console.WriteLine("I2 Interface Method");
	}

	public static void Main()
	{

		Program P = new Program();
		// Typecast in Interface
		((I1)P).InterfaceMethod();
		((I2)P).InterfaceMethod();

		Console.WriteLine("=============================");

		// Another way
		I1 i1 = new Program();
		I2 i2 = new Program();

		i1.InterfaceMethod();
		i2.InterfaceMethod();

	}
}