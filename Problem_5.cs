using System;

namespace SmartHomeDevices
{
   public class Device // Superclass: Device
   {
       public string DeviceId { get; set; }
       public string Status { get; set; }

       public Device(string deviceId, string status)
       {
           DeviceId = deviceId;
           Status = status;
       }

       public virtual void DisplayStatus()   // Virtual method to display device status
       {
           Console.WriteLine($"Device ID: {DeviceId}, Status: {Status}");
       }
   }

   public class Thermostat : Device // Subclass: Thermostat
   {
       public double TemperatureSetting { get; set; }

       public Thermostat(string deviceId, string status, double temperatureSetting)
           : base(deviceId, status)
       {
           TemperatureSetting = temperatureSetting;
       }

       public override void DisplayStatus()  // Override the DisplayStatus method to add temperature information
       {
           base.DisplayStatus();
           Console.WriteLine($"Temperature Setting: {TemperatureSetting} °C");
       }
   }

   class Program
   {
       static void Main(string[] args)
       {
           Thermostat thermostat = new Thermostat("TH-001", "Active", 23.5);
           thermostat.DisplayStatus();
       }
   }
}
