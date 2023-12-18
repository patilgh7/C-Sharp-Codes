using System;

/*
	Generic : 

	public static bool AreEqual(int Value1, int Value2)
	{
		return Value1 == Value2;
	}

	Basic purpose of generic is to we can use that method for any data type you want.In above code AreEqual method has only two int parameter to compare.
	If I want to compare string data type to be compare in that case above approach is not good.


	If you want make method generic that means I want to make this method independent of type it operates upon.
	For making Generic we use <T> => Type here we haven't mention datatype.

	Like below you can declare generic and compare

	public static bool AreEqual<T> (T Value1, T Value2)
	{
		return Value1.Equals(Value2);
	}

	In main method call that method but mention datatype in angular bracket like below

	bool Equal = Calculator.AreEqual <string>("A","A");



	And You can make class , delegate, struct generic

	public class Calculator<T>
	{
	
	}

	// call that Generic class in main method

	public static void Main()
	{
		bool Equal = Calculator<string>.AreEqual ("A", "A");
	}

*/


namespace Pragim
{
	public class MainClass
	{
		public static void Main()
		{
			bool Equal = Calculator.AreEqual <string>("A", "A");

			if(Equal)
			{
				Console.WriteLine("Equal");

			}
			else
			{
				Console.WriteLine("Not Equal");
			}
		}
	}


	public class Calculator
	{
		public static bool AreEqual<T> (T Value1, T Value2)
		{
			return Value1.Equals(Value2);
		}
	}
}