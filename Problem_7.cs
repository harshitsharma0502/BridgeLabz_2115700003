
using System;

namespace HospitalManagementSystem
{
    public class Client
    {
        static string ClinicName;
        static int PatientCount;

        readonly string ClientID;
        string FullName;
        int Age;
        string MedicalCondition;

        static Client()
        {
            ClinicName = "Sunrise Medical Center";
            PatientCount = 0;
        }

        public Client(string fullName, int age, string medicalCondition)
        {
            this.FullName = fullName;
            this.Age = age;
            this.MedicalCondition = medicalCondition;
            this.ClientID = "CLT" + (++PatientCount).ToString("D4");
        }

        public static void DisplayPatientCount()
        {
            Console.WriteLine("Total Clients Admitted: " + PatientCount);
        }

        public void ShowClientDetails()
        {
            Console.WriteLine("Clinic: " + ClinicName);
            Console.WriteLine("Client ID: " + ClientID);
            Console.WriteLine("Full Name: " + FullName);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Medical Condition: " + MedicalCondition);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("Vedant Sharma", 22, "Cold");
            if (client1 is Client)
            {
                client1.ShowClientDetails();
                Console.WriteLine();
            }

            Client client2 = new Client("Vicky Kumar", 22, "Headache");
            if (client2 is Client)
            {
                client2.ShowClientDetails();
                Console.WriteLine();
            }

            Client.DisplayPatientCount();
            Console.ReadLine();
        }
    }
}

