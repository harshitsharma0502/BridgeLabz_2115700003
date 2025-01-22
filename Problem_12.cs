using System;

class Program {
    public static void Main(string[] args) {
        Console.Write("Enter weight in pounds: ");
        double weightInPounds = double.Parse(Console.ReadLine());

        // Convert weight to kilograms
        double weightInKilograms = weightInPounds * 2.2;

        Console.WriteLine("The weight of the person in pounds is {0} and in kilograms is {1}",weightInPounds, weightInKilograms);
    }
}
