using System;

class Demo
{
	static void Main(){

		int TotalCoffeeCost = 0;
		int CoffeeCount = 0;


		Start:                  // Here Start is label to use ahead of goto
		Console.WriteLine("\n 1.Small \n 2.Medium \n 3.Large");

		int UserChoice = int.Parse(Console.ReadLine());

		switch(UserChoice)
		{
			case 1:
				CoffeeCount += 1;
				TotalCoffeeCost += 1;
				break;
			case 2:
				CoffeeCount += 1;
				TotalCoffeeCost += 2;
				break;
			case 3:
				CoffeeCount += 1;
				TotalCoffeeCost += 3;
				break;
			default:
				Console.WriteLine("Your Choice {0} is invalid", UserChoice);
				break;	
		}

		Decide:
		Console.WriteLine("Do you want to buy another coffee - Yes or No?");
		string UserDecision = Console.ReadLine();

		switch(UserDecision)
		{
			case "Yes": 
					goto Start;    // using goto statement you can jump directly to label where you have defined 
			case "No":
					break;
			default:
					Console.WriteLine("Your Choice is invalid. Please Try Again...");
					goto Decide;
		}
		Console.WriteLine("Your Choice {0} is invalid", UserChoice);
		Console.WriteLine("{0} Coffee ",CoffeeCount);
		Console.WriteLine("Bill Amount : {0} rs.", TotalCoffeeCost);

			

	}
}