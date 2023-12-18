using System;


public class Program
{
	public static void Main()
	{
		Customer C1 = new Customer();
		C1.Print();
	}
}


class Customer
{
	public void Print()
	{
		Console.WriteLine("Hello");
	}
}


/*

	If you don't mention public specifier like above => class Customer so by default it is internal access modifier

	So internal access modifier won't allow you to access out of that project means suppose there is another project called AssemblyOne 
	and you are accessing above Print() method in that project(Class Library) so it won't allow.

	Above class Customer Print method run in class Program because it is in same project

	When we use internal access modifier to class it simply means it is only available within wherever it is defined.If you trying to access that type
	outside of that somewhere it will give compiler error.



*/