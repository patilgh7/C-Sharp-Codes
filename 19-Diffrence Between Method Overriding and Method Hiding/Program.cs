using System;


// BaseClass and DerivedClass are used for Mehod Overriding

public class BaseClass
{
	public virtual void Print()
	{
		Console.WriteLine("I am a Base Class Print Method");
	}
}

public class DerivedClass : BaseClass
{
	public override void Print()
	{
		Console.WriteLine("I am a Derived Class Print Method");
	}
}


// Parent Class and Child Class are used for Method Hiding


public class ParentClass
{
	public void PrintName()
	{
		Console.WriteLine("This is Parent class PrintName Method");
	}
}

public class ChildClass : ParentClass
{
	public new void PrintName()
	{
		Console.WriteLine("This is Child Class PrintName Method");
	}
}

public class Program
{
	public static void Main()
	{

		BaseClass B = new DerivedClass();

		B.Print();


		ParentClass P = new ChildClass();

		P.PrintName();
	}
}