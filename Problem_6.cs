using System;

public class CarRental
{
    // Attributes
    public string CustomerName { get; set; }
    public string CarModel { get; set; }
    public int RentalDays { get; set; }
    public decimal CostPerDay { get; set; }

    // Constructor to initialize rental details
    public CarRental(string customerName, string carModel, int rentalDays, decimal costPerDay)
    {
        CustomerName = customerName;
        CarModel = carModel;
        RentalDays = rentalDays;
        CostPerDay = costPerDay;
    }

    // Method to calculate total cost
    public decimal CalculateTotalCost()
    {
        return RentalDays * CostPerDay;
    }

    // Display rental details
    public void DisplayRentalDetails()
    {
        Console.WriteLine($"Customer Name: {CustomerName}");
        Console.WriteLine($"Car Model: {CarModel}");
        Console.WriteLine($"Rental Days: {RentalDays}");
        Console.WriteLine($"Cost Per Day: {CostPerDay:C}");
        Console.WriteLine($"Total Cost: {CalculateTotalCost():C}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        Console.WriteLine("Enter customer name:");
        string customerName = Console.ReadLine();

        Console.WriteLine("Enter car model:");
        string carModel = Console.ReadLine();

        Console.WriteLine("Enter rental days:");
        int rentalDays = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter cost per day:");
        decimal costPerDay = decimal.Parse(Console.ReadLine());

        // Create CarRental object
        CarRental rental = new CarRental(customerName, carModel, rentalDays, costPerDay);

        // Display rental details
        Console.WriteLine("\nRental Details:");
        rental.DisplayRentalDetails();
    }
}