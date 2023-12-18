using System;

/*

	Note : 

	Check Customer C1 And C3 Object Equality in this code to understand concept.

*/

namespace Pragim
{
	public class MainClass
	{
		public static void Main()
		{
			int i = 10;
			int j = 10;

			Console.WriteLine(i == j);

			Console.WriteLine(i.Equals(j));


			// Comparing Directions

			Direction direction1 = Direction.East;
			Direction direction2 = Direction.West;	

			Console.WriteLine(direction1 == direction2);
			Console.WriteLine(direction1.Equals(direction2));


			// Customer Class

			Customer C1 = new Customer();

			C1.FirstName = "Gaurav";
			C1.LastName = "Patil";


			Customer C2 = C1;

			// Checking Reference Equality and  Checking Value Equality

			Console.WriteLine();
			Console.WriteLine("========================================================");
			Console.WriteLine("When we use '==' operator it gives Reference Equality");

			Console.WriteLine("When we use '.Equals()' method it gives Value Equality");
			Console.WriteLine("========================================================");

			Console.WriteLine();

			Console.WriteLine("Checking Reference Equality With C1 and C2 Object : " +(C1 == C2)); 


			Console.WriteLine("Checking Value Equality With C1 and C2 Object : " +(C1.Equals(C2)));



			Customer C3 = new Customer();

			C3.FirstName = "Gaurav";
			C3.LastName = "Patil";


			Console.WriteLine("Checking Reference Equality With C1 and C3 Object : " +(C1 == C3));

			// C1 and C3 object values are same FirstName = Gaurav and LastName = Patil 
			// But still we get False in output for below line ==> Console.WriteLine("Checking Value Equality : " +(C1.Equals(C3)));
			// Reason we use default .Equals method ...So thats why we override that .Equals Method in Customer Class to get correct output true
			// If you check difference in output please comment and uncomment Equals Method in Customer Class and compile the code you will see the difference 

			Console.WriteLine("Checking Value Equality With C1 and C3 Object : " +(C1.Equals(C3)));

			
		}
	}

	public enum Direction
	{
		East = 1,
		West = 2,
		North = 3,
		South = 4
	}


	public class Customer
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public override bool Equals(object obj)
		{
			if(obj == null)
			{	
				return false;
			}

			if(!(obj is Customer))
			{
				return false;
			}

			return this.FirstName == ((Customer)obj).FirstName && 
				   this.LastName == ((Customer)obj).LastName;
		}


		// You can not override only Equals method it will give warning 
		// With this you have to override GetHashCode() method also

		public override int GetHashCode()
		{
			return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
		}


	}
}