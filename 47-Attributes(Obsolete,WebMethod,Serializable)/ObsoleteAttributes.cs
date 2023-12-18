using System;
using System.Collections.Generic;


/*

	Attributes allow you to add declarative information to your programs. This information can then be queried at runtime using reflection.

	There are several Pre-defined Attributes provided by .NET. It is also possible to create your own Custom Attributes.

	A few pre-defined attributes with in the .NET framework

	Obsolete - Marks types and type members outdated

	WebMethod - To expose a method as an XML Web service method

	Serializable - Indicates that a class can be serialized

	It is possible to customize the attribute using parameters

	An attribute is a class that inherits from System.Attribute base class.


*/


public class MainClass
{
	public static void Main()
	{
		// Calling Obsolete method with 2 parameters it shows only warning
		Calculator.Add(10, 20);

		// Calling Obsolete method with 3 parameters it shows error
		//Calculator.Add(10, 20, 30);

		// Calling new method 
		Calculator.Add(new List<int>(){10,20,40});

	}
}


public class Calculator
{
	// Obsolete attribute when we used so it simply means outdated method....
	// When we use [Obsolete] attribute it shows that method is outdated you use newer method
	// When we use Obsolete method compiler gives warning message that this method is obsolete.
	// [Obsolete("Use Add(List<int> Numbers) Method")]  like this you can pass message to that method so it will show as a warning message.
	//  warning CS0618: 'Calculator.Add(int, int)' is obsolete: 'Use Add(List<int> Numbers) Method'
	// [Obsolete("Use Add(List<int> Numbers) Method", true)] if you pass true as second parameter..
	// ...it gives error...that means you are strongly preventing to use this method with 3 parameter
	// error CS0619: 'Calculator.Add(int, int, int)' is obsolete: 'Use Add(List<int> Numbers)

	// [Obsolete]
	// [Obsolete("Give Message Here It Shows As A Warning")]
	// [Obsolete("Give Message Here",true)]  => Error shows

	[Obsolete("Use Add(List<int> Numbers) Method")]
	public static int Add(int FirstNumber, int SecondNumber)
	{

		Console.WriteLine("Addition = "+(FirstNumber+SecondNumber));

		return FirstNumber + SecondNumber;

	}



	[Obsolete("Use Add(List<int> Numbers) Method", true)]
	public static int Add(int FirstNumber, int SecondNumber, int ThirdNumber)
	{

		Console.WriteLine("Addition = "+(FirstNumber+SecondNumber+ThirdNumber));

		return FirstNumber + SecondNumber + ThirdNumber;

	}



	public static int Add(List<int> Numbers)
	{
		int Sum = 0;

		foreach(int Number in Numbers)
		{
			Sum = Sum + Number;
		}

		Console.WriteLine("Addition = "+Sum);
		return Sum;
	}
}