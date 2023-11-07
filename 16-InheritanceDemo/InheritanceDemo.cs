using System;

public class Employee
{
	public string FirstName;
	public string LastName;
	public string Email;

	public virtual void PrintFullName()
	{
		Console.WriteLine("Name : {0} {1} \nEmail : {2}", FirstName, LastName,Email);
	}
}

public class FullTimeEmployee : Employee
{
	public  float YearlySalary;

}

public class PartTimeEmployee : Employee
{
	public float HourlyRate;
}

public class InheritanceDemo
{
	public static void Main()
	{
		FullTimeEmployee FTE = new FullTimeEmployee();
		FTE.FirstName = "Gaurav";
		FTE.LastName = "Patil";
		FTE.Email = "gp@gamail.com";
		FTE.YearlySalary = 50000;

		FTE.PrintFullName();
	}
}