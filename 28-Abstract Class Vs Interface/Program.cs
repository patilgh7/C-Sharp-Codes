using System;


// Difference Between Abstract Class And Interface

public abstract class Customer
{
	// abstract class can contains fully implemented method or only method declaration and it contains fields also

	// By default abstract class members are private

	// Abstract Class contain access modifiers


	int ID;

	public abstract void Print1();


	public void Print2()
	{
		Console.WriteLine("Print 2 ");
	}

}

public interface ICustomer
{
	// Interface can not contains fields like   => int ID;

	// Interfaces are by default public so yo need not to mention public access modifier to the method.

	// It only contains method declaration

	// Interface does not contain access modifiers

	void print();
}


public class CustImpl : Customer
{

	// When you provide abstract class method implementation ...you have to add override keyword to that method implementation.

	public override void Print1()
	{
		Console.WriteLine("Print 1");
	}
}


public class Program 
{
	public static void Main()
	{
		CustImpl C1 = new CustImpl();
		C1.Print1();
		C1.Print2();
	}
}