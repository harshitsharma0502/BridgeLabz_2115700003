using System;
using System.Collections.Generic;

// Abstract class Vehicle
public abstract class Vehicle
{
    public string VehicleNumber { get; private set; }
    public string Type { get; private set; }
    public decimal RentalRate { get; protected set; }

    protected Vehicle(string vehicleNumber, string type, decimal rentalRate)
    {
        VehicleNumber = vehicleNumber;
        Type = type;
        RentalRate = rentalRate;
    }

    public abstract decimal CalculateRentalCost(int days);
}

// Interface for insurable vehicles
public interface IInsurable
{
    decimal CalculateInsurance();
    string GetInsuranceDetails();
}

// Car subclass
public class Car : Vehicle, IInsurable
{
    private string insurancePolicyNumber;

    public Car(string vehicleNumber, decimal rentalRate, string insurancePolicy)
        : base(vehicleNumber, "Car", rentalRate)
    {
        insurancePolicyNumber = insurancePolicy;
    }

    public override decimal CalculateRentalCost(int days)
    {
        return days * RentalRate;
    }

    public decimal CalculateInsurance()
    {
        return RentalRate * 0.05m; // Insurance at 5% of the rental rate
    }

    public string GetInsuranceDetails()
    {
        return $"Car Insurance Policy: {insurancePolicyNumber}";
    }
}

// Bike subclass
public class Bike : Vehicle
{
    public Bike(string vehicleNumber, decimal rentalRate)
        : base(vehicleNumber, "Bike", rentalRate)
    {
    }

    public override decimal CalculateRentalCost(int days)
    {
        return days * RentalRate * 0.8m; // Discounted rate for bikes
    }
}

// Truck subclass
public class Truck : Vehicle, IInsurable
{
    private string insurancePolicyNumber;

    public Truck(string vehicleNumber, decimal rentalRate, string insurancePolicy)
        : base(vehicleNumber, "Truck", rentalRate)
    {
        insurancePolicyNumber = insurancePolicy;
    }

    public override decimal CalculateRentalCost(int days)
    {
        return days * RentalRate * 1.5m; // Premium rate for trucks
    }

    public decimal CalculateInsurance()
    {
        return RentalRate * 0.1m; // Insurance at 10% of the rental rate
    }

    public string GetInsuranceDetails()
    {
        return $"Truck Insurance Policy: {insurancePolicyNumber}";
    }
}

// Main program to demonstrate polymorphism
public class Program
{
    public static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("CAR123", 50m, "POL12345"),
            new Bike("BIKE456", 20m),
            new Truck("TRUCK789", 100m, "POL67890")
        };

        foreach (var vehicle in vehicles)
        {
            int rentalDays = 5;
            Console.WriteLine($"Vehicle: {vehicle.Type}, Number: {vehicle.VehicleNumber}");
            Console.WriteLine($"Rental Cost for {rentalDays} days: ${vehicle.CalculateRentalCost(rentalDays)}");

            if (vehicle is IInsurable insurableVehicle)
            {
                Console.WriteLine($"Insurance Cost: ${insurableVehicle.CalculateInsurance()}");
                Console.WriteLine(insurableVehicle.GetInsuranceDetails());
            }

            Console.WriteLine();
        }
    }
}
