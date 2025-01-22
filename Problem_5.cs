using System;

class Program {
    public static void Main(string[] args) {
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine());

        double celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine("The {0} Fahrenheit is {1} Celsius", fahrenheit, celsius);
    }
}
