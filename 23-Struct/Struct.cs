using System;

public struct Customer
{

	private int _id;
	private string _name;


	public int ID
	{
		get
		{
			return this._id;
		}

		set
		{
			this._id = value;
		}
	}


	public string Name
	{
		get
		{
			return this._name;
		}

		set
		{
			this._name = value;
		}
	}


	public Customer(int Id, string Name)
	{
		this._id = Id;
		this._name = Name;
	}


	public void PrintDetails()
	{
			Console.WriteLine("Id = {0} && Name = {1} ", this._id,this._name);
	}


}


public class Program
{
	public static void Main()
	{
		Customer C1 = new Customer(101, "Gaurav");
		C1.PrintDetails();

		Customer C2 = new Customer();
		C2.ID = 102;
		C2.Name = "Patil";
		C2.PrintDetails();


		Customer C3 = new Customer()
		{
			ID = 103,
			Name = "John"	
		};

		C3.PrintDetails();

	}
}