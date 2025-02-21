using System;
class Program
{
    static int PerformDivision(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new DivideByZeroException("Denominator cannot be zero");
        }
        return numerator / denominator;
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter numerator: ");
            int numerator = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int denominator = Convert.ToInt32(Console.ReadLine());

            int result = PerformDivision(numerator, denominator);
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input: Please enter valid integers.");
        }
        finally
        {
            Console.WriteLine("Operation completed");
        }
    }
}
