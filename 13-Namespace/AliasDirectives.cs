using System;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;

class NamespaceDemo
{

	public static void Main()
	{
		
		// To avoid ambiguity between TeamA and TeamB Print method we use alias directives

		PATA.ClassA.Print();  

		PATB.ClassA.Print();  
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