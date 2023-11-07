using System;

public class ExceptionHandling
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter Numerator: ");
            int Numerator;
            bool IsNumeratorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Numerator);

            if (IsNumeratorConversionSuccessful)
            {
                Console.WriteLine("Enter Denominator: ");
                int Denominator;
                bool IsDenominatorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Denominator);

                if (IsDenominatorConversionSuccessful)
                {
                    if (Denominator != 0)
                    {
                        int Result = Numerator / Denominator;
                        Console.WriteLine("Result = {0} ", Result);
                    }
                    else
                    {
                        Console.WriteLine("Denominator should not be zero");
                    }
                }
                else
                {
                    DisplayDenominatorError();
                }
            }
            else
            {
                DisplayNumeratorError();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void DisplayNumeratorError()
    {
        Console.WriteLine("Numerator should be valid between {0} and {1}.", Int32.MinValue, Int32.MaxValue);
    }

    private static void DisplayDenominatorError()
    {
        Console.WriteLine("Denominator should be valid between {0} and {1}.", Int32.MinValue, Int32.MaxValue);
    }
    
}
