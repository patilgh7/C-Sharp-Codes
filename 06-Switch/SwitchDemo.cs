using System;

class Demo
{
	static void Main(){


		// Console.WriteLine("Please Enter Number : ");

		// int UserNumber = int.Parse(Console.ReadLine());

		// if(UserNumber == 10)
		// {
		// 	Console.WriteLine("Your Number is 10");
		// }
		// else if(UserNumber == 20)
		// {
		// 	Console.WriteLine("Your Number is 20");

		// }
		// else if(UserNumber == 30)
		// {
		// 	Console.WriteLine("Your Number is 30");
		// }
		// else if(UserNumber == 40)
		// {
		// 	Console.WriteLine("Your Number is 40");
		// }
		// else
		// {
		// 	Console.WriteLine("Your Number is not 10,20,30,40");
		// }



		// You can write above code using switch also ...you need not write if else ladder code everytime


		Console.WriteLine("Please Enter Number : ");

		int UserNumber = int.Parse(Console.ReadLine());


		switch(UserNumber)
		{
			case 10:
				Console.WriteLine("Your Number is 10");
				break;
			case 20:
				Console.WriteLine("Your Number is 20");
				break;
			case 30:
				Console.WriteLine("Your Number is 30");
				break;
			case 40:
				Console.WriteLine("Your Number is 40");
				break;
			default:
				Console.WriteLine("Your Number is not 10,20,30,40");
				break;
		}



	}
}