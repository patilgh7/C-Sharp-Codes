using System;
using System.Collections.Generic;



public class Program
{
	public static void Main()
	{
		/*
			List<Employee> empList = new List<Employee>();

			Employee employee = new Employee();
			employee.ID = 101;
			employee.Name = "Mary";
			employee.Salary = 5000;
			employee.Experience = 5;

			empList.Add(employee);

		*/

		// Another way to add employees

		List<Employee> empList = new List<Employee>();

		empList.Add(new Employee() {ID = 101, Name = "Mary", Salary = 5000, Experience = 5});
		empList.Add(new Employee() {ID = 101, Name = "Mike", Salary = 4000, Experience = 4});
		empList.Add(new Employee() {ID = 101, Name = "John", Salary = 6000, Experience = 6});
		empList.Add(new Employee() {ID = 101, Name = "Todd", Salary = 3000, Experience = 3});


		Employee.PromoteEmployee(empList);
	}
}

class Employee
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

	// In the long form, you explicitly define a private backing field (in this case, ,_salary, _experience) and 
	// provide custom logic in the getter and setter methods.
	// you can set properties like below 

	private int _salary;
	private int _experience;

	public int Salary
	{
		get
		{
			return this._salary;
		}

		set
		{	
			this._salary = value;
		}
	}


	public int Experience
	{
		get
		{
			return this._experience;
		}

		set
		{
			this._experience = value;
		}
	}



    public static void PromoteEmployee(List<Employee> employeeList)
    {
    	foreach(Employee employee in employeeList)
    	{
    		if(employee.Experience >= 5)
    		{
    			Console.WriteLine(employee.Name + " promoted");
    		}
    	}
    }

}