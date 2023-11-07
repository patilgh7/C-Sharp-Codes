using System;


class Customer
{
	string _firstName;
	string _lastName;

	// This is constructor with no name
	public Customer() 
		: this("No FirstName Provided","No LastName Provided")
	{	
			
	}

	// This is constructor with name
	public Customer(string FirstName, string LastName)
	{
		this._firstName = FirstName;
		this._lastName = LastName;
	}

	public void PrintFullName()
	{
		Console.WriteLine("Full Name = {0} ",_firstName +" "+_lastName);
	}

}




class Program
{
	static void Main()
	{
		Customer C1 = new Customer("Gaurav","Patil");
		C1.PrintFullName();


		Customer C2 = new Customer();
		C2.PrintFullName();
		
	}
}