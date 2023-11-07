using System;


class MethodDemo
{
	public static void Main()
	{
		MethodDemo demo = new MethodDemo();

		MethodDemo.EvenNumbers(30);

		int Sum = demo.Add(10, 40);

		Console.WriteLine("Sum = {0} ",Sum);
	}

	public int Add(int FN, int SN)
	{
		return FN + SN;
	}

	public static void EvenNumbers(int Target)
	{
		int Start = 0;

		while(Start <= Target)
		{
			Console.WriteLine(Start);

			Start = Start + 2;

		}
	}
}