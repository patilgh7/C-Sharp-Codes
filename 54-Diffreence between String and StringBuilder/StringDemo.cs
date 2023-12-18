

/*

	String : 


	When we use string ...string is immutable that means when object is created you can not change

	below example userString = C# it creates one object afterthat we added userString += Video in that userString 

	so it creates another object C# Video likethat other strings are added to that userString ....

	It will create everytime new objects  : (C#)	(C# Video) (C# Video Tutorial) (C# Video Tutorial For) (C# Video Tutorial For Beginners)  

											obj1	  obj2		   obj3				   obj4					    obj5
											
	Immutable means once object created you can't change that object so when 

	we add strings it will craete objects again and again.

	These multiple objects created in heap memory

*/

/*

	StringBuilder : 

	StringBuilder is mutable that means it can be change over a time.

	And It can not create multiple object like string when you added mutiple strings...
	It creates only one object when you add multiple strings to that particular object of StringBuilder..
	In our case 'strBuilder' this is the object of StringBuilder and we are appending strings to this object. 

	

*/

using System;
using System.Text;


namespace pragim
{
	public class MainClass
	{
		public static void Main()
		{

			string userString = "C# ";

			userString += "Video ";
			userString += "Tutorial ";
			userString += "For ";
			userString += "Beginners";

			Console.WriteLine("Using String : ");
			Console.WriteLine(userString);

			Console.WriteLine();
			
			Console.WriteLine("Using StringBuilder : ");
			StringBuilder strBuilder = new StringBuilder("Video ");
			strBuilder.Append("Lectures ");
			strBuilder.Append("On StringBuilder");
			Console.WriteLine(strBuilder.ToString());


			// Example of string 
			Console.WriteLine();
			Console.WriteLine("String example : ");
			string str = string.Empty;
			for(int i = 1; i <= 10; i++)
			{
				str += i.ToString() + " ";
			}
			Console.WriteLine(str);


			Console.WriteLine();
			Console.WriteLine("StringBuilder example : ");
			StringBuilder sb = new StringBuilder();
			for(int i = 10; i <= 20; i++)
			{
				sb.Append(i.ToString()).Append(" ");
			}


			Console.WriteLine(sb);

		}
	}
}