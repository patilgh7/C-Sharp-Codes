using System;

class MethodDemo_2
{

	public static void Main()
	{
		// When we use params keyword we can pass as many we want the numbers directly 

		Console.WriteLine("Params Array : ");
		ParamsMethod(10,20,30,40,50);

		Console.WriteLine("=================");

		// Normal Method call

		int[] arr = new int[3];

		arr[0] = 5;
		arr[1] = 6;
		arr[2] = 7;

		Console.WriteLine("Normal Array : ");
		NormalMehod(arr);
	}


	// If you want pass array as a parameter so use 'params' keyword

	public static void ParamsMethod(params int[] Numbers)
	{
		Console.WriteLine("There are {0} elements ", Numbers.Length);

		foreach(int i in Numbers)
		{
			Console.WriteLine(i);
		}
	}


	// Normal array method

	public static void NormalMehod(int[] Num)
	{
		Console.WriteLine("There are {0} elements ",Num.Length);

		foreach(int i in Num)
		{
			Console.WriteLine(i);
		}
	}
	
}