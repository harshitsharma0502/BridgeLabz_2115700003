using System;

namespace VehicleRegistrationSystem
{
    public class Transport
    {
        static double FeeForRegistration;
        static int TransportCounter;

        readonly string TransportID;
        string OwnerFullName;
        string VehicleCategory;

        static Transport()
        {
            FeeForRegistration = 5000.0;
            TransportCounter = 0;
        }

        public Transport(string ownerFullName, string vehicleCategory)
        {
            this.OwnerFullName = ownerFullName;
            this.VehicleCategory = vehicleCategory;
            this.TransportID = "TID" + (++TransportCounter).ToString("D4");
        }

        public static void SetRegistrationFee(double newFee)
        {
            FeeForRegistration = newFee;
            Console.WriteLine("Registration fee updated to: " + FeeForRegistration);
        }

        public void ShowTransportDetails()
        {
            Console.WriteLine("Transport ID: " + TransportID);
            Console.WriteLine("Owner Name: " + OwnerFullName);
            Console.WriteLine("Vehicle Category: " + VehicleCategory);
            Console.WriteLine("Registration Fee: " + FeeForRegistration);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Transport.SetRegistrationFee(6000.0);

            Transport transport1 = new Transport("Alice Johnson", "Car");
            if (transport1 is Transport)
            {
                transport1.ShowTransportDetails();
                Console.WriteLine();
            }

            Transport transport2 = new Transport("Bob Smith", "Motorcycle");
            if (transport2 is Transport)
            {
                transport2.ShowTransportDetails();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}