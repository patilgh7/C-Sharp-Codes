using System;
using System.Collections.Generic;


// We simply use lambda expression to reduce lines of code of delegate 

public class Program
{
	public static void Main()
	{

		Employee emp = new Employee();

		emp.ID = 101;
		emp.Name = "Mary";
		emp.Salary = 5000;
		emp.Experience = 5;

		List<Employee> empList = new List<Employee>();

		empList.Add(emp);

		empList.Add(new Employee(){ID = 102, Name = "John", Salary = 6000, Experience = 6});

		empList.Add(new Employee(){ID = 103, Name = "Jasmin", Salary = 2000, Experience = 2});


		// Using lambda function here (e => e.Experience >= 5) directly
		Employee.PromotedEmployee(empList, e => e.Experience >= 5);

	}


	
}



public delegate bool IsPromotable(Employee empl);

public class Employee
{
	// Auto implemented properties
	public int ID
	{
		get;
		set;
	}

	public string Name
	{
		get;
		set;
	}


	// Manual implemented properties

	private int _salary;
	private int _experience;

	public int Salary
	{
		get
		{
			return _salary;
		}

		set
		{
			_salary = value;
		}
	}


	public int Experience
	{
		get
		{
			return _experience;
		}

		set
		{
			_experience = value;
		}
	}


	// In this method we have pass delegate (IsPromotable IsEligibleToPromote) as  a parameter
	public static void PromotedEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
	{
		foreach(Employee employee in employeeList)
		{
			if(IsEligibleToPromote(employee))
			{
				Console.WriteLine(employee.Name +" Promoted");
			}
		}
	}
}



