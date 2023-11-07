using System;



// classes, structs, enums, interfaces, delegates are called as 'Types'
// fields, properties, constructors, methods are called as 'Type members'

// For Types we can only use public and internal access modifiers
// For Type Members we use private, protected, internal, protected internal, public all these access modifiers.


// Note : we can use #region and #endregion to define our regions like fields, method 
// This #region and #endregion shows properly region in IDEs like Visual Studio.

public class Customer
{

	// These are fields kept private for encapsulation

	#region Fields
	private int _id;
	private string _firstName;
	private string _lastName;
	#endregion




	// Providing above fields properties (Getter and Setter)
	#region Properties 
	public int Id
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



	public string FirstName
	{
		get
		{
			return _firstName;
		}

		set
		{
			_firstName = value;
		}
	}


	public string LastName
	{
		get
		{
			return _lastName;
		}

		set
		{
			_lastName = value;
		}
	}

	#endregion


	#region Method
	public string GetFullName()
	{
		return this._firstName + " " + this._lastName;
	}

	#endregion
}


public class Program
{
	public static void Main()
	{
		Customer C1 = new Customer();

		C1.Id = 101;
		C1.FirstName = "Sachin";
		C1.LastName = "Tendulkar";

		Console.WriteLine(C1.GetFullName());


	}
}