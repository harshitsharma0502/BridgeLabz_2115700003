using System;

class Program {
    public static void Main(string[] args) {
        Console.Write("Enter first side of the park (m): ");
        double side1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second side of the park (m): ");
        double side2 = double.Parse(Console.ReadLine());
        Console.Write("Enter third side of the park (m): ");
        double side3 = double.Parse(Console.ReadLine());

        double perimeter = side1 + side2 + side3;
        int rounds = (int)Math.Ceiling(5000 / perimeter);

        Console.WriteLine("The total number of rounds the athlete will run is {0} to complete 5 km", rounds);
    }
}
