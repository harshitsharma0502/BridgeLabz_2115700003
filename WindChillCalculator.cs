using System;

class WindChillCalculator
{
    // Method to calculate the wind chill temperature
    public double CalculateWindChill(double temperature, double windSpeed)
    {
        // Formula to calculate wind chill
        double windChill = 35.74 + (0.6215 * temperature) + ((0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16));

        return windChill;
    }

    public static void Main(string[] args)
    {
        // Take user input for temperature and wind speed
        Console.WriteLine("Enter the temperature (in Fahrenheit):");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the wind speed (in miles per hour):");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        // Create an object of WindChillCalculator
        WindChillCalculator calculator = new WindChillCalculator();

        // Call the method to calculate wind chill
        double windChill = calculator.CalculateWindChill(temperature, windSpeed);

        // Display the result rounded to 2 decimal places
        Console.WriteLine("The wind chill temperature is: " + windChill.ToString("F2") + " °F");
    }
}
