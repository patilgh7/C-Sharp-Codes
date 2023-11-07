using System;
using System.Collections.Generic;

public class Test
{
	public static void Main()
	{
		List<Employee> empList = new List<Employee>();

		Employee employee = new Employee();
		employee.ID = 101;
		employee.Name = "John";
		employee.Salary = 3000;
		employee.Experience = 3;

		empList.Add(employee);

		// Another way to add employees 
		empList.Add(new Employee(){ID = 102, Name = "Abhi", Salary = 2000, Experience = 2});
		empList.Add(new Employee(){ID = 103, Name = "Ron", Salary = 6000, Experience = 6});

		Employee.PromotedEmployee(empList);

	}
}


class Employee
{
	private int _id;
	private string _name;


	// Manual implemented properties keeping fields as a private _id and _name

	public int ID
	{
		get
		{
			return _id;
		}

		set
		{
			_id = value;
		}
	}

	public string Name
	{
		get
		{
			return _name;
		}

		set
		{
			_name = value;
		}
	}


	// Auto implemented properties

	public int Salary
	{
		get;
		set;
	}

	public int Experience
	{
		get;
		set;
	}


	public static void PromotedEmployee(List<Employee> employeeList)
	{
		foreach(Employee employee in employeeList)
		{
			if(employee.Experience >= 3)
			{
				Console.WriteLine(employee.Name + " Promoted ");
			}
		}
	}

}