using System;

class BasicCalculator {
    public static void Main(string[] args) {
        // Take user input for two numbers
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Perform operations
        double addition = num1 + num2;
        double subtraction = num1 - num2;
        double multiplication = num1 * num2;
        double division = num1 / num2;

        // Display the results
        Console.WriteLine("The addition is " + addition + ", subtraction is " + subtraction + ", multiplication is " + multiplication + ", and division is " + division);
    }
}
