using System;

// Multicast delegate using same instance of delegate.

// Using delegate return type integer


/* If the delegate has a return type other than void and if the delegate is multicast delegate ,
   only the value of the last invoked method will be returned.

*/

   
public delegate int SampleDelegate();

class Program
{
	public static void Main()
	{
		SampleDelegate del1 = new SampleDelegate(SampleMethodOne);

		del1 += SampleMethodTwo;
	
		int DelegateReturnedValue = del1();

		Console.WriteLine("Delegate Returned Value = {0} ", DelegateReturnedValue);


		// It return last method invoked value
	}

	public static int SampleMethodOne()
	{
		return 1;
	}

	public static int SampleMethodTwo()
	{
		return 2;
	}

	
}