using System;
using ProjectA.TeamA;

class NamespaceDemo
{

	public static void Main()
	{
		// ProjectA.TeamA.ClassA.Print();   you can call method like this fully qualified name or another way 'using' keyword 

		ClassA.Print();   // you can call like this declaring 'using' keyword above

		ProjectA.TeamB.ClassA.Print();  // fully qualified name
	}


}

namespace ProjectA
{
	namespace TeamA
	{
		class ClassA
		{
			public static void Print()
			{
				Console.WriteLine("Team A Print Method ");
			}
		}
	}
}


namespace ProjectA
{
	namespace TeamB
	{
		class ClassA
		{
			public static void Print()
			{
				Console.WriteLine("Team B Print Method");
			}
		}
	}
}