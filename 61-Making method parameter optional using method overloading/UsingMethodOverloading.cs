using System;


// 	2) Method overloading 

public class OptionalParameter
{
	public static void Main()
	{
		// calling with 2 parameters
		AddNumbers(20,30);

		// calling with 4 parameters
		AddNumbers(10,20, new int[]{30,40});
	}


	public static void AddNumbers(int firstNumber, int secondNumber)
	{
		AddNumbers(firstNumber,secondNumber,null);
	}

	public static void AddNumbers(int firstNumber, int secondNumber, int[] restOfNumbers)
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