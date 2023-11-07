using System;
using System.IO;

/*
	

	ex.StackTrace => StackTrace will give exactly where your program causes exception or giving exact error.

	ex.Message => Give Message


	Note : One more thing to note you can not right catch block where you mention Parent class first then next catch block of child class 
		   it will give error.

		try
		{
			StreamReader stream_reader = new StreamReader(@"D:\C Sharp\35-Exception Handling\Data.txt");
			Console.WriteLine(stream_reader.ReadToEnd());
			stream_reader.Close();
		}
		catch(Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		catch(FileNotFoundException ex)
		{
			Console.WriteLine("Please check if the file {0} exists", ex.FileName);
		}


		Here Exception is Parent class and FileNotFoundException is Child class so this is not the way write catch block 
		it will give error that "A previous catch clause already catches all exceptions of this or of a super type ('System.Exception')"

		So basically we write like below code First FileNotFoundException and then Exception if you want to mention multiple catch block

*/

public class ExceptionHandling
{
	public static void Main()
	{
		try
		{
			StreamReader stream_reader = new StreamReader(@"D:\C Sharp\35-Exception Handling\Data.txt");
			Console.WriteLine(stream_reader.ReadToEnd());
			stream_reader.Close();
		}
		catch(FileNotFoundException ex)
		{
			Console.WriteLine("Please check if the file {0} exists", ex.FileName);
		}
		catch(Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		
		
	}
}