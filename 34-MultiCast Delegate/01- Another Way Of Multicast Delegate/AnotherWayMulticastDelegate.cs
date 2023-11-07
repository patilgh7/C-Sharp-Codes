using System;

// Multicast delegate using same instance of delegate.


public delegate void SampleDelegate();

class Program
{
	public static void Main()
	{
		SampleDelegate del1 = new SampleDelegate(SampleMethodOne);

		// Using 'plus equal to sign' we can achieve multicasting delegate And you can remove delegate Using 'minus equal to sign'.

		del1 += SampleMethodTwo;
		del1 += SampleMethodThree;

		del1();

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