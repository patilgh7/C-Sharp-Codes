using System;


interface I1
{
	void InterfaceMethod();
}

interface I2
{
	void InterfaceMethod();
}

public class Program2 : I1, I2
{

	// Default implementation of I1 inteface method

	public void InterfaceMethod()
	{
		Console.WriteLine("I1 Interface Method");
	}


	// Explicit implementation of I2 interface method
	// When you use interface name and apply dot operator on it and write method name and provide method implementation i.e. explicit implementation 
	void I2.InterfaceMethod()
	{
		Console.WriteLine("I2 Interface Method");
	}


	public static void Main()
	{
		Program2 P = new Program2();
		P.InterfaceMethod();
		((I2)P).InterfaceMethod();
	}
}