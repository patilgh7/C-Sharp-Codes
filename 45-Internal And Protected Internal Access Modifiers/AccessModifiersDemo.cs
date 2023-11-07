using System;



/*

		Access Modifiers				Accessibility

		internal 						Anywhere in the containing assembly

		protected internal 				Anywhere in the containing assembly and from within a derived class in any other assembly.

		==============================================================================================================================


		A member with internal access modifiers is available anywhere in the containing assembly. It's a compile time error to access
		an internal member from outside the containing assembly.

		==============================================================================================================================

		Note : 

		For better understanding of internal access modifier we have to create project through Visual Studio IDE. 


		In .net When you compile a project an assembly is generated. 
		In .net basically assemblies are two types : 1) executables (.exe)  2) dynamic link library (.dll)
		Generally "console application" generates .exe  whereas " web application and class library " generates .dll
	
		==============================================================================================================================

*/

public class MainClass
{
	public static void Main()
	{

	}
}