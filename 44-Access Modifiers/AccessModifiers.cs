using System;


/*

		Access Modifiers				Accessibility

		private 						only with in containing class

		public 							Any where, no restrictions

		protected						With in the containing types and the types derived from the containing type

*/



public class Customer
{
	private int _id;


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
}


public class CustomerService
{
	protected int serviceNumber;
}



public class OnlineService : CustomerService
{

	public int PrintServiceNumber()
	{
		OnlineService OS = new OnlineService();

		OS.serviceNumber = 1234;

		return OS.serviceNumber;

	}
}

public class MainClass
{
	public static void Main()
	{
		OnlineService onlineService = new OnlineService();

		Console.WriteLine(onlineService.PrintServiceNumber());
	}
}