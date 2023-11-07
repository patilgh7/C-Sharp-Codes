using System;

class Demo
{
	static void Main(){

		int TotalCoffeeCost = 0;

		Console.WriteLine("\n 1.Small \n 2.Medium \n 3.Large");

		int UserChoice = int.Parse(Console.ReadLine());

		switch(UserChoice)
		{
			case 1:
				TotalCoffeeCost += 1;
				break;
			case 2:
				TotalCoffeeCost += 2;
				break;
			case 3:
				TotalCoffeeCost += 3;
				break;
			default:
				Console.WriteLine("Your Choice {0} is invalid", UserChoice);
				break;	
		}

			Console.WriteLine("Your Choice {0} is invalid", UserChoice);
			Console.WriteLine("Bill Amount : {0} rs.", TotalCoffeeCost);
			

	}
}