using System;

class MethodDemo_2
{

	public static void Main()
	{
		int Sum = 0;
		int Product = 0;
		Calculate(50,20,out Sum, out Product);

		Console.WriteLine("Sum = {0} && Product = {1} ",Sum, Product);
	}

	// Here Calculate Method returns 2 values sum and product 

	public static void Calculate(int FN, int SN, out int Sum, out int Product)
	{
		Sum = FN + SN;

		Product = FN * SN;
	}

	
}