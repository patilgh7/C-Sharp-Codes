using System;
using System.IO;


/*
	StreamReader  stream_reader = null;

	try
	{
		stream_reader = new StreamReader(@"D:\C Sharp\35-Exception Handling\finally block1\Data.txt");
		Console.WriteLine(stream_reader.ReadToEnd());
			
	}
	Error Occur : 
	Unhandled Exception: System.NullReferenceException: Object reference not set to an instance of an object.
   	at ExceptionHandling.Main()


   	Because We declare stream_reader = null when it goes to try block it thows exception because of we provided wrong path
   	of file so stream_reader will remain null so throws above NullReferenceException. So correct that we need write null check code as well.


	finally
	{
		if(stream_reader != null)
		{
			stream_reader.Close();
		}
		
	}

*/


public class ExceptionHandling
{
	public static void Main()
	{
		StreamReader  stream_reader = null;

		try
		{
			stream_reader = new StreamReader(@"D:\C Sharp\35-Exception Handling\finally block\Data.txt");
			Console.WriteLine(stream_reader.ReadToEnd());
			
		}
		catch(FileNotFoundException ex)
		{
			Console.WriteLine("Please check if the file {0} exists", ex.FileName);
		}
		catch(Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		finally
		{
			/*
			 
			 -In Exception code we see try catch block 
			 -Why finally block is important => Because When we get an exception at line 12 StreamReader that stream_reader object can not closed yet
			 -When exception occurs in try block at that moment program stops executing program at that line...if we write stream_reader.Close() in 
			  try block how can we reach the next line...
			 -So we use finally block because no matter what exception occurs or not occurs this block will always executed. 
			*/

			if(stream_reader != null)
			{
				stream_reader.Close();
			}
			
			Console.WriteLine("Finally Block");
		}
		
		
	}
}