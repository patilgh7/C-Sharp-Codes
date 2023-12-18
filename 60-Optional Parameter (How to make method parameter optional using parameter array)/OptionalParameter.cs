using System;


/*
	There are 4 ways to make method parameter optional

	1) Use parameter array =>   Note to be consider => When you use parameter array for making parmeter optional ...
	   Parameter array must be last parameter in method 
	2) Method overloading
	3) Specify parameter defaults
	4) Use OptionalAttribute that is present in System.Runtime.InteropServices namespace

*/

public class OptionalParameter
{
	public static void Main()
	{
		// With only two parameters
		AddNumbers(10,20);

		// 30,40,50 we are adding optional parameters
		AddNumbers(10,20,30,40,50);
	}

	public static void AddNumbers(int firstNumber, int secondNumber, params object[] restOfNumbers)
	{
		int result = firstNumber + secondNumber;

		if(restOfNumbers != null)
		{
			foreach(int i in restOfNumbers)
			{
				result += i;
			}
		}
	

		Console.WriteLine("Sum = "+result);
		 

	}
}