using System;

class Program {
    public static void Main(string[] args) {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("The {0} Celsius is {1} Fahrenheit", celsius, fahrenheit);
    }
}
