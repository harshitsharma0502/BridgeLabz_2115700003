using System;
using System.Collections.Generic;


namespace HospitalDoctorsPatient
{
    public class Hospital
    {
        public List<Doctor> Doctors = new List<Doctor>();
        public List<Patient> Patients  = new List<Patient>();
    }


    public class Doctor
    {
        public string Name { get; set; }
        public List<Patient> Patients= new List<Patient>();


        public Doctor(string name)
        {
            Name = name;
        }


        public void Consult(Patient patient)
        {
            if (!Patients.Contains(patient))
            {
                Patients.Add(patient);
                patient.Doctors.Add(this);
            }
            Console.WriteLine(string.Format("Doctor {0} is consulting Patient {1}", Name, patient.Name));
        }
    }


    public class Patient
    {
        public string Name { get; set; }
        public List<Doctor> Doctors= new List<Doctor>();


        public Patient(string name)
        {
            Name = name;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();


            Doctor doctor1 = new Doctor("Dr. Smith");
            Doctor doctor2 = new Doctor("Dr. Jones");


            Patient patient1 = new Patient("John Doe");
            Patient patient2 = new Patient("Jane Doe");


            hospital.Doctors.Add(doctor1);
            hospital.Doctors.Add(doctor2);
            hospital.Patients.Add(patient1);
            hospital.Patients.Add(patient2);


            doctor1.Consult(patient1);
            doctor1.Consult(patient2);
            doctor2.Consult(patient1);


            // Output the consultations
            foreach (var doctor in hospital.Doctors)
            {
                Console.WriteLine(string.Format("{0} has consulted the following patients:", doctor.Name));
                foreach (var patient in doctor.Patients)
                {
                    Console.WriteLine(string.Format("- {0}", patient.Name));
                }
            }


            foreach (var patient in hospital.Patients)
            {
                Console.WriteLine(string.Format("{0} has consulted the following doctors:", patient.Name));
                foreach (var doctor in patient.Doctors)
                {
                    Console.WriteLine(string.Format("- {0}", doctor.Name));
                }
            }
        }
    }
}
