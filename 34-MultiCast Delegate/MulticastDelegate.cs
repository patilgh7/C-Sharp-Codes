using System;

// Multicast delegate is a delegate that has referenes to more than one function

// Multicast delegate using different instance of delegate.

// Purpose Of Multicast delegate is to make implementation of observer design pattern


public delegate void SampleDelegate();

class Program
{
	public static void Main()
	{
		SampleDelegate del1, del2, del3, del4;

		del1 = new SampleDelegate(SampleMethodOne);
		del2 = new SampleDelegate(SampleMethodTwo);
		del3 = new SampleDelegate(SampleMethodThree);
		
		// del4 is pointing to all del1, del2, del3 methods
		// simply del4 is pointing to 3 other functions so del4 is called as multiast delegate
		// How do we delegate multicasted by chaining the delegates together with 'plus sign' And you can remove delegate Using 'minus sign'.
		del4 = del1 + del2 + del3;

		// When we call del4 this will call all the methods at a time that are invoked by del4
		del4();


	}

	public static void SampleMethodOne()
	{
		Console.WriteLine("Sample Method One Invoked");
	}

	public static void SampleMethodTwo()
	{
		Console.WriteLine("Sample Method Two Invoked");
	}

	public static void SampleMethodThree()
	{
		Console.WriteLine("Sample Method Three Invoked");
	}
}