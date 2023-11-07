using System;

public class Parent
{
	public Parent()
	{
		Console.WriteLine("This is Parent Class Constructor");
	}
}

public class Child : Parent
{
	public Child()
	{
		Console.WriteLine("This is Child Class Constructor");
	}
}



public class Program
{
	static void Main()
	{
		Child C = new Child();
	}
}