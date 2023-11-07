using System;


public class Student
{

	// Here all fields are encapsulated making fields as a private and using of getter and setter method

	// Here we only provide getter method for _passMark field for read only access to user not a write access 
	// if we provide setter method to _passMark field then user will get write access.

	private int _id;
	private string _name;
	private int _passMark = 35;


	public int GetPassMark()
	{
		return this._passMark;
	}


	public void SetName(string Name)
	{
		if(string.IsNullOrEmpty(Name))
		{
			throw new Exception("Student Name cannot be null or empty.");
		}

		this._name = Name;
	}


	public string GetName()
	{
		if(string.IsNullOrEmpty(this._name))
		{
			return "No Name";
		}
		else
		{
			return this._name;
		}

		

		// you can use below 1 line ternary operator instead of above if-else code.

		// return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
	}


	public void SetId(int Id)
	{
		if(Id <= 0)
		{
			throw new Exception("Student Id cannot be negative.");
		}

		this._id = Id;
	}


	public int GetId()
	{
		return this._id;
	}
}


public class Program
{
	public static void Main()
	{
		Student C1 = new Student();
		C1.SetId(101);
		C1.SetName("Gaurav");

		Console.WriteLine("Student Id = {0} ", C1.GetId());
		Console.WriteLine("Student Id = {0} ", C1.GetName());
		Console.WriteLine("Pass Mark = {0} ", C1.GetPassMark());
	}
}