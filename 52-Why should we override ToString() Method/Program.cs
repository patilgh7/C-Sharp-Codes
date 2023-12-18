using System;


namespace Pragim
{
	public class MainClass
	{
		public static void Main()
		{
			int Number = 10;

			Console.WriteLine(Number.ToString());

			Customer C1 = new Customer();

			C1.FirstName = "Gaurav";
			C1.LastName = "Patil";

			Console.WriteLine(C1.ToString());
		}
	}


	public class Customer
	{

		// Properties
		public string FirstName { get; set; }
	

		public string LastName { get; set; }

		// override method

		public override string ToString()
		{
			return LastName +" "+ FirstName;
		}
	}
}