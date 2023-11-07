using System;

// When you make method virtual you can override that method

// This is Example Diamond Problem or Multiple Inheritance Problem 


// A is base class => B And C are inherit from A class => But D class can not inherit by 2 classes B and C at same time

class A
{
	public virtual void Print()
	{
		Console.WriteLine("A Implementation");
	}
}


class B : A
{
	public override void Print()
	{
		Console.WriteLine("B Implementation");
	}
}


class C : A
{
	public override void Print()
	{
		Console.WriteLine("C Implementation");
	}
}


class D : B,C
{

}



public class Program
{
	public static void Main()
	{

	}
}