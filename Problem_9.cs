
using System;

public class Vehicle
{
    // Instance variables
    public string OwnerName;
    public string VehicleType;

    // Class variable
    public static decimal RegistrationFee;

    // Constructor
    public Vehicle(string ownerName, string vehicleType)
    {
        OwnerName = ownerName;
        VehicleType = vehicleType;
    }

    // Instance method to display vehicle details
    public void DisplayVehicleDetails()
    {
        Console.WriteLine($"Owner Name: {OwnerName}");
        Console.WriteLine($"Vehicle Type: {VehicleType}");
        Console.WriteLine($"Registration Fee: {RegistrationFee:C}");
    }

    // Class method to update the registration fee
    public static void UpdateRegistrationFee(decimal newFee)
    {
        RegistrationFee = newFee;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Set the initial registration fee
        Vehicle.UpdateRegistrationFee(500.00m);

        // Create vehicle objects
        Vehicle vehicle1 = new Vehicle("John Doe", "Car");
        Vehicle vehicle2 = new Vehicle("Jane Smith", "Motorcycle");
        Vehicle vehicle3 = new Vehicle("Sam Brown", "Truck");

        // Display vehicle details
        Console.WriteLine("Vehicle 1 Details:");
        vehicle1.DisplayVehicleDetails();

        Console.WriteLine("\nVehicle 2 Details:");
        vehicle2.DisplayVehicleDetails();

        Console.WriteLine("\nVehicle 3 Details:");
        vehicle3.DisplayVehicleDetails();

        // Update registration fee
        Console.WriteLine("\nUpdating Registration Fee...\n");
        Vehicle.UpdateRegistrationFee(600.00m);

        // Display updated vehicle details
        Console.WriteLine("Updated Vehicle 1 Details:");
        vehicle1.DisplayVehicleDetails();

        Console.WriteLine("\nUpdated Vehicle 2 Details:");
        vehicle2.DisplayVehicleDetails();

        Console.WriteLine("\nUpdated Vehicle 3 Details:");
        vehicle3.DisplayVehicleDetails();
    }
}

using System;

public class Vehicle
{
    // Instance variables
    public string OwnerName;
    public string VehicleType;

    // Class variable
    public static decimal RegistrationFee;

    // Constructor
    public Vehicle(string ownerName, string vehicleType)
    {
        OwnerName = ownerName;
        VehicleType = vehicleType;
    }

    // Instance method to display vehicle details
    public void DisplayVehicleDetails()
    {
        Console.WriteLine($"Owner Name: {OwnerName}");
        Console.WriteLine($"Vehicle Type: {VehicleType}");
        Console.WriteLine($"Registration Fee: {RegistrationFee:C}");
    }

    // Class method to update the registration fee
    public static void UpdateRegistrationFee(decimal newFee)
    {
        RegistrationFee = newFee;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Set the initial registration fee
        Vehicle.UpdateRegistrationFee(500.00m);

        // Create vehicle objects
        Vehicle vehicle1 = new Vehicle("John Doe", "Car");
        Vehicle vehicle2 = new Vehicle("Jane Smith", "Motorcycle");
        Vehicle vehicle3 = new Vehicle("Sam Brown", "Truck");

        // Display vehicle details
        Console.WriteLine("Vehicle 1 Details:");
        vehicle1.DisplayVehicleDetails();

        Console.WriteLine("\nVehicle 2 Details:");
        vehicle2.DisplayVehicleDetails();

        Console.WriteLine("\nVehicle 3 Details:");
        vehicle3.DisplayVehicleDetails();

        // Update registration fee
        Console.WriteLine("\nUpdating Registration Fee...\n");
        Vehicle.UpdateRegistrationFee(600.00m);

        // Display updated vehicle details
        Console.WriteLine("Updated Vehicle 1 Details:");
        vehicle1.DisplayVehicleDetails();

        Console.WriteLine("\nUpdated Vehicle 2 Details:");
        vehicle2.DisplayVehicleDetails();

        Console.WriteLine("\nUpdated Vehicle 3 Details:");
        vehicle3.DisplayVehicleDetails();
    }
}