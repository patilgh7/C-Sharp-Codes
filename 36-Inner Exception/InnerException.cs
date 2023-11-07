using System;
using System.IO;

/*
		string filePath = @"D:\C Sharp\36-Inner Exception\Log.txt";
		StreamWriter sw = new StreamWriter(filePath);
		sw.Write(ex.GetType().Name);
		sw.WriteLine();
		sw.Write(ex.Message);

		Above line of code write exception in Log.txt file whichever exception is occured during program running.

*/

/*
		
		To understand the concept of inner exception we have considered two cases
		1) We have to change file name of Log.txt to => Log1.txt  ......It will gives us FileNotFoundException
		2) Enter First Number lets say = 10 then Enter Second Number = 0 ...So basically we are dividing first number by zero ....So it will give
		   DivideByZero Excepption....This is our inner exception...It is basically handled two exceptions

*/

class InnerException
{
	public static void Main()
	{
		try
		{
			// This is the try block which is use to handle outer exception

			try
			{    

				// This is the try block which is use to handle inner exception

				Console.WriteLine("Enter the number :");
				int FN = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Enter the second number :");
				int SN = Convert.ToInt32(Console.ReadLine());

				int Result = FN / SN;

				Console.WriteLine("Result = {0}", Result);
			}
			catch(Exception ex)
			{
				string filePath = @"D:\C Sharp\36-Inner Exception\Log.txt";

				if(File.Exists(filePath))
				{
					StreamWriter sw = new StreamWriter(filePath);
					sw.Write(ex.GetType().Name);
					sw.WriteLine();
					sw.Write(ex.Message);
					sw.Close();
					Console.WriteLine("There is a problem, Please try later");
				}
				else
				{
					throw new FileNotFoundException(filePath + "is not present",ex);   // ex => it shows inner exception if occurs
				}
			}



		}    // This is end of outer try block
		catch(Exception exception)
		{
			Console.WriteLine("Current Exception = {0} ",exception.GetType().Name);

			// To avoid null reference exception we check below condition

			if(exception.InnerException != null)
			{
				Console.WriteLine("Inner Exception = {0} ",exception.InnerException.GetType().Name);
			}
			
		}
		

	}
}