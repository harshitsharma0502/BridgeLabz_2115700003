using System;

public class Vehicle // Base class Vehicle
{
   public int MaxSpeed;
   public string FuelType;

   public Vehicle(int maxSpeed, string fuelType)
   {
       MaxSpeed = maxSpeed;
       FuelType = fuelType;
   }

   public virtual void DisplayDetails()
   {
       Console.WriteLine($"Max Speed: {MaxSpeed} km/h, Fuel Type: {FuelType}");
   }
}

public class Car : Vehicle // Derived class Car
{
   public int SeatCapacity;

   public Car(int maxSpeed, string fuelType, int seatCapacity)
       : base(maxSpeed, fuelType)
   {
       SeatCapacity = seatCapacity;
   }

   public override void DisplayDetails()
   {
       base.DisplayDetails();
       Console.WriteLine($"Seat Capacity: {SeatCapacity}");
   }
}

public class Truck : Vehicle
{
   public int PayloadCapacity;

   public Truck(int maxSpeed, string fuelType, int payloadCapacity)
       : base(maxSpeed, fuelType)
   {
       PayloadCapacity = payloadCapacity;
   }

   public override void DisplayDetails()
   {
       base.DisplayDetails();
       Console.WriteLine($"Payload Capacity: {PayloadCapacity} kg");
   }
}

public class MotorCycle : Vehicle
{
   public bool HasSidecar;

   public MotorCycle(int maxSpeed, string fuelType, bool hasSidecar)
       : base(maxSpeed, fuelType)
   {
       HasSidecar = hasSidecar;
   }

   public override void DisplayDetails()
   {
       base.DisplayDetails();
       Console.WriteLine($"Has Sidecar: {HasSidecar}");
   }
}

public class Program
{
   public static void Main(string[] args)
   {
       Vehicle[] vehicles = new Vehicle[3];
       vehicles[0] = new Car(200, "Petrol", 2);
       vehicles[1] = new Truck(100, "Diesel", 1000);
       vehicles[2] = new MotorCycle(150, "Petrol", false);

       foreach (Vehicle vehicle in vehicles)
       {
           vehicle.DisplayDetails();
           Console.WriteLine();
       }
   }
}
