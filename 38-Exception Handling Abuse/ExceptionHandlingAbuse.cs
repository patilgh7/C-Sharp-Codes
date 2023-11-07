using System;



public class ExceptionHandlingAbuse
{

	public static void Main()
	{
		try
		{
			Console.WriteLine("Enter Numerator");
			int Numerator = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Denominator");
			int Denominator = Convert.ToInt32(Console.ReadLine());

			int Result = Numerator / Denominator;

			Console.WriteLine("Result = {0} ", Result);
		}
		catch(FormatException)
		{
			Console.WriteLine("Please enter a only number.");
		}
		catch(OverflowException)
		{
			Console.WriteLine("Only Numbers Between {0} & {1} are allowed. ", Int32.MinValue, Int32.MaxValue);
		}
		catch(DivideByZeroException)
		{
			Console.WriteLine("Denominator can not be zero.");
		}
		catch(Exception ex)
		{
			Console.WriteLine(ex.Message);
		}

	}
}