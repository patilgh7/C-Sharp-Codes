using System;


public class Program
{
	public static void Main()
	{
		Add(55.5f, 28.2f);
	}

	public static void Add(int FN, int SN)
	{
		Console.WriteLine("Sum = {0} ",FN + SN);
	}

	public static void Add(int FN, int SN, int TN)
	{
		Console.WriteLine("Sum = {0} ",FN + SN + TN);
	}

	public static void Add(float FN, float SN)
	{
		Console.WriteLine("Sum = {0} ",FN + SN);
	}


	
}