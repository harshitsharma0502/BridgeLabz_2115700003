using System;

class Program {
    public static void Main(string[] args) {
        Console.Write("Enter Principal amount: ");
        double principalAmount = double.Parse(Console.ReadLine());

        Console.Write("Enter Rate of Interest (%): ");
        double interestRate = double.Parse(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        double timePeriod = double.Parse(Console.ReadLine());

        // Calculate Simple Interest
        double simpleInterest = (principalAmount * interestRate * timePeriod) / 100;
        Console.WriteLine("The Simple Interest is {0} for Principal {1}, Rate of Interest {2}% and Time {3} years.",simpleInterest, principalAmount, interestRate, timePeriod);
    }
}
