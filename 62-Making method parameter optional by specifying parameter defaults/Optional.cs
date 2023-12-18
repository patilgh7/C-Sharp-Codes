using System;

  // 3) specifying parameter defaults => here in our example Test method has three parameters a,b,c
  //      But b and c has default values 10 and 20 respectively.
  //      If I want to change the value of b paramter i.e. by default 10 and I want to make it 25 then so the syntax is  => Test(5, b : 25);



public class OptionalParameter
{
	public static void Main()
	{
		// call the method
		Test(1);
		Console.WriteLine("==========================");
		Test(5, b:25);
		Console.WriteLine("==========================");
		Test(16, c:17);
		Console.WriteLine("==========================");
	}


	public static void Test(int a, int b = 10, int c = 20)
	{
		Console.WriteLine(" a = "+a);
		Console.WriteLine(" b = "+b);
		Console.WriteLine(" c = "+c);
	}

}