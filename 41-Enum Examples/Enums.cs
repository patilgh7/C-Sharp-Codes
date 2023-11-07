using System;


// Why we use enums

// =>  Below Program we have " public static string GetGender(int gender) " method consist switch 
//     and we have use multiple switch cases 0, 1 , 2 like so program become extremly unreadable, unmaintanable so thats why we use enums.


// Some changes done in this code ...(refer code-40 folder)

public class Enums
{
	public static void Main()
	{
		Customer[] customers = new Customer[3];

		customers[0] = new Customer
		{
			Name = "Mark",
			Gender = Gender.Male         // change
		};

		customers[1] = new Customer
		{
			Name = "Mary",
			Gender = Gender.Female       // change
		}; 

		customers[2] = new Customer
		{
			Name = "Sam",
			Gender = Gender.Unknown      // change
		};


		foreach(Customer customer in customers)
		{
			Console.WriteLine("Name = {0} && Gender = {1} ", customer.Name, GetGender(customer.Gender));
		}
	}


	public static string GetGender(Gender gender)           // here we have changed parameter type 'int' to enum 'Gender'     
	{
		switch(gender)
		{
			case Gender.Unknown :        // change
				return "Unknown";
			case Gender.Male :           // change
				return "Male";
			case Gender.Female :         // change
				return "Female";
			default :
				return "Invalid data";			
		}
	}
}


// 0 - Unknown
// 1 - Male
// 2 - Female

public enum Gender
{
	Unknown,
	Male,
	Female
}


public class Customer
{
	public string Name { get; set; }
	public Gender Gender { get; set; }             // here we have changed return type 'int' to 'Gender'


}