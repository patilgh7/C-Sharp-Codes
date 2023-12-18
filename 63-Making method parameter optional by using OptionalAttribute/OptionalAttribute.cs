using System;
using System.Runtime.InteropServices;

// Using Optional Attribute
// AddNumbers method third parameter is optional so the syntax is =>   [Optional] int[] restOfNumbers

public class OptionalParmeter
{

	public static void Main()
	{
		// call with 2 parameters
		AddNumbers(10,20);

		// call with 4 parameters
		AddNumbers(10, 20, new int[]{50, 60});
	}

	public static void AddNumbers(int firstNumber, int secondNumber, [Optional] int[] restOfNumbers)
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