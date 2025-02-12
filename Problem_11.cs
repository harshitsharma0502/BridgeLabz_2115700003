
using System;
public class Vehicle
{
   public int MaxSpeed { get; set; }
   public string Model { get; set; }

   public Vehicle(int maxSpeed, string model)
   {
       MaxSpeed = maxSpeed;
       Model = model;
   }

   public void DisplayInfo()
   {
       Console.WriteLine($"Model: {Model}, Max Speed: {MaxSpeed} km/h");
   }
}

public interface Refuelable
{
   void Refuel();
}

public class ElectricVehicle : Vehicle
{
   public int BatteryCapacity { get; set; }

   public ElectricVehicle(int maxSpeed, string model, int batteryCapacity)
       : base(maxSpeed, model)
   {
       BatteryCapacity = batteryCapacity;
   }

   public void Charge()
   {
       Console.WriteLine($"{Model} is charging its battery with {BatteryCapacity} kWh capacity.");
   }
}

public class PetrolVehicle : Vehicle, Refuelable
{
   public int FuelCapacity { get; set; }

   public PetrolVehicle(int maxSpeed, string model, int fuelCapacity)
       : base(maxSpeed, model)
   {
       FuelCapacity = fuelCapacity;	
   }

   public void Refuel()
   {
       Console.WriteLine($"{Model} is refueling with {FuelCapacity} liters capacity.");
   }
}

class Program
{
   static void Main(string[] args)
   {
       ElectricVehicle tesla = new ElectricVehicle(200, "Tesla Model S", 100);
       tesla.DisplayInfo();
       tesla.Charge();
       PetrolVehicle mustang = new PetrolVehicle(250, "Ford Mustang", 60);
       mustang.DisplayInfo();
       mustang.Refuel();
   }
}

