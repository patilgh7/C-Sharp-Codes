using System;


public class Employee
{
	public string FirstName;
	public string LastName;


	public void PrintFullName()
	{
		Console.WriteLine(FirstName+" "+LastName);
	}
}

public class PartTimeEmployee : Employee
{

	// Mention new keyword when you use same method as parent class in child class 

	public new void PrintFullName()
	{

		Console.WriteLine(FirstName+" "+LastName + " - Contractor");
	}
}

public class FullTimeEmployee : Employee
{

}

public class Program
{
	static void Main()
	{	

		FullTimeEmployee FTE = new FullTimeEmployee();	
		FTE.FirstName = "FullTime";
		FTE.LastName = "Employee";
		FTE.PrintFullName();

		PartTimeEmployee PTE = new PartTimeEmployee();	
		PTE.FirstName = "PartTime";
		PTE.LastName = "Employee";
		PTE.PrintFullName();


	}
}