using System;

class Program {
    public static void Main(string[] args) {
        // Take user inputs
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter starting city: ");
        string fromCity = Console.ReadLine();
        
        Console.Write("Enter via city: ");
        string viaCity = Console.ReadLine();
        
        Console.Write("Enter destination city: ");
        string toCity = Console.ReadLine();
        
        Console.Write("Enter distance from {0} to {1} (in miles): ", fromCity, viaCity);
        double fromToVia = double.Parse(Console.ReadLine());
        
        Console.Write("Enter distance from {0} to {1} (in miles): ", viaCity, toCity);
        double viaToFinalCity = double.Parse(Console.ReadLine());
        
        Console.Write("Enter time taken for the journey (in hours): ");
        double timeTaken = double.Parse(Console.ReadLine());

        // Calculate total distance
        double totalDistance = fromToVia + viaToFinalCity;

        // Calculate average speed (Speed = Distance / Time)
        double averageSpeed = totalDistance / timeTaken;

        // Output results in the specified format
        Console.WriteLine("The results of the trip are: {0}, {1}, and {2}", totalDistance, averageSpeed, timeTaken);
    }
}
