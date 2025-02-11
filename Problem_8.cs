using System;
using System.Collections.Generic;

// Abstract Class
public abstract class Vehicle
{
    // Encapsulated private fields
    private string vehicleId;
    private string driverName;
    private double ratePerKm;

    // Properties to access private fields
    public string VehicleId
    {
        get { return vehicleId; }
        set { vehicleId = value; }
    }

    public string DriverName
    {
        get { return driverName; }
        set { driverName = value; }
    }

    public double RatePerKm
    {
        get { return ratePerKm; }
        set { ratePerKm = value; }
    }

    // Constructor
    protected Vehicle(string vehicleId, string driverName, double ratePerKm)
    {
        this.vehicleId = vehicleId;
        this.driverName = driverName;
        this.ratePerKm = ratePerKm;
    }

    // Abstract method
    public abstract double CalculateFare(double distance);

    // Concrete method
    public void GetVehicleDetails()
    {
        Console.WriteLine($"Vehicle ID: {vehicleId}, Driver: {driverName}, Rate per Km: {ratePerKm}");
    }
}

// Interface
public interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

// Car subclass
public class Car : Vehicle, IGPS
{
    private string currentLocation;

    public Car(string vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
    }
}

// Bike subclass
public class Bike : Vehicle, IGPS
{
    private string currentLocation;

    public Bike(string vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
    }
}

// Auto subclass
public class Auto : Vehicle, IGPS
{
    private string currentLocation;

    public Auto(string vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
    }
}

// Main program to demonstrate polymorphism
class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("CAR123", "Alice", 15),
            new Bike("BIKE456", "Bob", 10),
            new Auto("AUTO789", "Charlie", 12)
        };

        double distance = 25; // Example distance

        foreach (var vehicle in vehicles)
        {
            vehicle.GetVehicleDetails();
            Console.WriteLine($"Fare for {distance} km: {vehicle.CalculateFare(distance)}");
            Console.WriteLine();
        }
    }
}
