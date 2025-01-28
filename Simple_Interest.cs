using System;

class SimpleInterest
{
    // Method to calculate simple interest
    // This method takes the principal amount, rate of interest, and time period as input 
    // and returns the calculated simple interest.
    public double CalculateSimpleInterest(int principal, double rate, int time)
    {
        // Formula for simple interest: (Principal × Rate × Time) / 100
        double simpleInterest = (principal * rate * time) / 100;
        return simpleInterest;
    }

    public static void Main(string[] args)
    {
        // Prompt the user to enter the principal amount
        Console.WriteLine("Enter the principal");
        int principal = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to enter the rate of interest
        Console.WriteLine("Enter the rate");
        double rate = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the time period
        Console.WriteLine("Enter the time");
        int time = Convert.ToInt32(Console.ReadLine());

        // Create an instance of the SimpleInterest class to call the method
        SimpleInterest simpleInterestCalculator = new SimpleInterest();

        // Call the method to calculate simple interest using the user inputs
        double simpleInterest = simpleInterestCalculator.CalculateSimpleInterest(principal, rate, time);

        // Format the result string using string.Format and display the calculated interest
        string result = string.Format(
            "The Simple Interest is {0} for Principal {1}, Rate of Interest {2}, and Time {3}",
            simpleInterest, principal, rate, time
        );
        Console.WriteLine(result);
    }
}
