using System;

// When you want to call parameterized constructor in child class when 2 constructors are present 

public class Parent
{
	public Parent()
	{
		Console.WriteLine("This is Parent Class Constructor");
	}

	// Parameterized Costructor of Parent class

	public Parent(string Message)
	{
		Console.WriteLine(Message);
	}

}

public class Child : Parent
{
	public Child() : base("Derived Class Controlling Parent Class")
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