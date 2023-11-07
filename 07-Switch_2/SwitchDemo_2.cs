using System;

class Demo
{
	static void Main(){

		// Multiple case statement together (fall through)

		Console.WriteLine("Please Enter Number : ");

		int UserNumber = int.Parse(Console.ReadLine());


		switch(UserNumber)
		{
			case 10:
			case 20:
			case 30:
				Console.WriteLine("Your Number is {0} ",UserNumber);
				break;
			default:
				Console.WriteLine("Your Number is not 10,20,30");
				break;
		}



	}
}