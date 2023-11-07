using System;


public class EnumDemo
{
	public static void Main()
	{

		// Here Enum is class and GetValues and GetNames are method of Enum Class

		int[] values = (int[])Enum.GetValues(typeof(Gender));

		foreach(int Value in values)
		{
			Console.WriteLine(Value);
		}

		string[] Names = Enum.GetNames(typeof(Gender));

		foreach(string Name in Names)
		{
			Console.WriteLine(Name);
		}



		// ===

		long[] divisions = (long[])Enum.GetValues(typeof(Divisons));

		foreach(int Division in divisions)
		{
			Console.WriteLine(Division);
		}

	}
}


public enum Gender
{
	Unknown = 1,              // When we don't specify number here then it automatically considers '0'  otherwise you can assign a number like this.
	Male,
	Female
}

public enum Divisons : long        // like this you can change type of enum by default it is integer here we have made it long datatype
{
	A = 123,
	B,
	C
}