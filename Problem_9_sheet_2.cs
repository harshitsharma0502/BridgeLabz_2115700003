using System;

class BasicCalculator
{
    // Function to perform addition
    public static double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    // Function to perform subtraction
    public static double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    // Function to perform multiplication
    public static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    // Function to perform division
    public static double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return num1 / num2;
    }

    // Method to get a valid double input from the user
    public static double GetDoubleInput(string prompt)
    {
        double number;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (double.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    // Main method to interact with the user
    public static void Main(string[] args)
    {
        Console.WriteLine("Basic Calculator");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.Write("Choose an operation (1-4): ");
        string choice = Console.ReadLine();

        double num1, num2;
        string result;

        switch (choice)
        {
            case "1":
                num1 = GetDoubleInput("Enter first number: ");
                num2 = GetDoubleInput("Enter second number: ");
                result = String.Format("{0} + {1} = {2}", num1, num2, Add(num1, num2));
                break;

            case "2":
                num1 = GetDoubleInput("Enter first number: ");
                num2 = GetDoubleInput("Enter second number: ");
                result = String.Format("{0} - {1} = {2}", num1, num2, Subtract(num1, num2));
                break;

            case "3":
                num1 = GetDoubleInput("Enter first number: ");
                num2 = GetDoubleInput("Enter second number: ");
                result = String.Format("{0} * {1} = {2}", num1, num2, Multiply(num1, num2));
                break;

            case "4":
                num1 = GetDoubleInput("Enter first number: ");
                num2 = GetDoubleInput("Enter second number: ");
                try
                {
                    result = String.Format("{0} / {1} = {2}", num1, num2, Divide(num1, num2));
                }
                catch (DivideByZeroException ex)
                {
                    result = ex.Message;
                }
                break;

            default:
                result = "Invalid operation. Please choose a number between 1 and 4.";
                break;
        }

        Console.WriteLine(result);
    }
}