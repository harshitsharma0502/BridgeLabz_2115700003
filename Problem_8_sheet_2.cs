using System;

class TemperatureConverter
{
    // Function to convert Fahrenheit to Celsius
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        double celsius = (fahrenheit - 32) * 5.0 / 9.0;
        return celsius;
    }

    // Function to convert Celsius to Fahrenheit
    public static double CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = (celsius * 9.0 / 5.0) + 32;
        return fahrenheit;
    }

    // Main method to interact with the user
    public static void Main(string[] args)
    {
        Console.WriteLine("Temperature Converter");
        Console.WriteLine("1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");
        Console.Write("Choose an option (1 or 2): ");
        string choice = Console.ReadLine();

        double temperature;
        string result;

        switch (choice)
        {
            case "1":
                Console.Write("Enter temperature in Fahrenheit: ");
                if (double.TryParse(Console.ReadLine(), out temperature))
                {
                    double celsius = FahrenheitToCelsius(temperature);
                    result = String.Format("{0}° Fahrenheit is {1}° Celsius.", temperature, celsius);
                }
                else
                {
                    result = "Invalid input. Please enter a valid number.";
                }
                break;

            case "2":
                Console.Write("Enter temperature in Celsius: ");
                if (double.TryParse(Console.ReadLine(), out temperature))
                {
                    double fahrenheit = CelsiusToFahrenheit(temperature);
                    result = String.Format("{0}° Celsius is {1}° Fahrenheit.", temperature, fahrenheit);
                }
                else
                {
                    result = "Invalid input. Please enter a valid number.";
                }
                break;

            default:
                result = "Invalid option. Please choose 1 or 2.";
                break;
        }

        Console.WriteLine(result);
    }
}