using System;

public class Student
{
	private int _id;
	private string _name;
	private int _passMark = 35;
	// private string _city;
	// private string _email;



	// In C Sharp syntax is little bit different than our getter setter method.

	// In C Sharp we use set keyword and value keyword ....In setter method we provide parameter instead of that parameter we write value keyword
	// And for get accessor we use get keyword. 

    // Setter Method 
    /*
		public void SetId(int Id)
		{
			if(Id <= 0)
			{
				throw new Exception("Student Id cannot be negative");

			}
			this._id = Id;	
		}
	*/

	// Getter Method
	/*
		public int GetId()
		{
			return this._id;
		}

	*/

	// we can do that using properties in C Sharp to set and get the value instead of getter and setter method
	// So lets check the below code. 

	public int Id 
	{
		set
		{
			if(value <= 0)
			{
				throw new Exception("Student Id cannot be negative");
			}
			this._id = value;
		}

		get
		{
			return this._id;
		}
	}

	// In above code public int Id => so Id is Property and set and get are the accessors ...
	// value keyword will contain the value which we are assigning to the property. 
	// so basically value keyword we are using instead of parameter which we passes in setter method.
	// Note : value keyword we only use in set accessor ....we don't use value keyword in get accessor.


	public string Name
	{
		set
		{
			if(string.IsNullOrEmpty(value))
			{
				throw new Exception("Student Name cannot be null or empty");
			}
			this._name = value;
		}

		get
		{
			return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
		}
	}


	public int PassMark
	{
		get
		{
			return this._passMark;
		}
	}



/*

	public string Email
	{
		get
		{
			return this._email;
		}

		set
		{
			this._email = value;
		}
	}


	public string City
	{
		get
		{
			return this._city;
		}

		set
		{
			this._city = value;
		}
	}

*/ 


	// for city and email you can use auto implemented properties feature...so compiler will create private anonymous fileds 
	// and get and set accessors for that fields.

	public string City
	{
		get;
		set;
	}

	public string Email
	{
		get;
		set;
	}

}



public class Program
{
	public static void Main()
	{
		Student C1 = new Student();
		C1.Id = 101;
		C1.Name = "Gaurav";

		C1.City = "Kolhapur";
		C1.Email = "gp@gmail.com";

		Console.WriteLine("Student Id = {0} ",C1.Id);
		Console.WriteLine("Student Name = {0} ",C1.Name);
		Console.WriteLine("PassMark = {0} ",C1.PassMark);
		Console.WriteLine("City = {0} ",C1.City);
		Console.WriteLine("Email = {0} ",C1.Email);
	}
}