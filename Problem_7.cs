using System;
using System.Collections.Generic;

// Abstract class Patient
public abstract class Patient
{
    public string PatientId { get; private set; }
    public string Name { get; private set; }
    public int Age { get; private set; }

    protected Patient(string patientId, string name, int age)
    {
        PatientId = patientId;
        Name = name;
        Age = age;
    }

    public abstract double CalculateBill();

    public string GetPatientDetails()
    {
        return $"Patient ID: {PatientId}, Name: {Name}, Age: {Age}";
    }
}

// Interface for medical records
public interface IMedicalRecord
{
    void AddRecord(string record);
    void ViewRecords();
}

// InPatient subclass
public class InPatient : Patient, IMedicalRecord
{
    private double dailyCharge;
    private int numberOfDays;
    private List<string> medicalRecords;

    public InPatient(string patientId, string name, int age, double dailyCharge, int numberOfDays)
        : base(patientId, name, age)
    {
        this.dailyCharge = dailyCharge;
        this.numberOfDays = numberOfDays;
        medicalRecords = new List<string>();
    }

    public override double CalculateBill()
    {
        return dailyCharge * numberOfDays;
    }

    public void AddRecord(string record)
    {
        medicalRecords.Add(record);
        Console.WriteLine("Record added successfully.");
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical Records:");
        foreach (var record in medicalRecords)
        {
            Console.WriteLine(record);
        }
    }
}

// OutPatient subclass
public class OutPatient : Patient, IMedicalRecord
{
    private double consultationFee;
    private List<string> medicalRecords;

    public OutPatient(string patientId, string name, int age, double consultationFee)
        : base(patientId, name, age)
    {
        this.consultationFee = consultationFee;
        medicalRecords = new List<string>();
    }

    public override double CalculateBill()
    {
        return consultationFee;
    }

    public void AddRecord(string record)
    {
        medicalRecords.Add(record);
        Console.WriteLine("Record added successfully.");
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical Records:");
        foreach (var record in medicalRecords)
        {
            Console.WriteLine(record);
        }
    }
}

// Main program to demonstrate polymorphism
public class Program
{
    public static void Main(string[] args)
    {
        List<Patient> patients = new List<Patient>
        {
            new InPatient("P001", "John Doe", 45, 500.0, 5),
            new OutPatient("P002", "Jane Smith", 32, 200.0)
        };

        foreach (var patient in patients)
        {
            Console.WriteLine(patient.GetPatientDetails());
            Console.WriteLine($"Bill Amount: ${patient.CalculateBill()}");

            if (patient is IMedicalRecord recordablePatient)
            {
                recordablePatient.AddRecord("Initial Diagnosis: Stable condition.");
                recordablePatient.ViewRecords();
            }

            Console.WriteLine();
        }
    }
}
