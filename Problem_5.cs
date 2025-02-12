
using System;

namespace UniversityStudentManagement
{
    public class Learner
    {
        static string CollegeName;
        static int StudentCount;

        readonly string EnrollmentNumber;
        string FullName;
        string AcademicGrade;

        static Learner()
        {
            CollegeName = "National College";
            StudentCount = 0;
        }

        public Learner(string fullName, string enrollmentNumber, string academicGrade)
        {
            this.FullName = fullName;
            this.EnrollmentNumber = enrollmentNumber;
            this.AcademicGrade = academicGrade;
            StudentCount++;
        }

        public static void ShowTotalStudents()
        {
            Console.WriteLine("Total Students Enrolled: " + StudentCount);
        }

        public void ShowLearnerDetails()
        {
            Console.WriteLine("College: " + CollegeName);
            Console.WriteLine("Full Name: " + FullName);
            Console.WriteLine("Enrollment Number: " + EnrollmentNumber);
            Console.WriteLine("Academic Grade: " + AcademicGrade);
        }

        public void ChangeGrade(string newGrade)
        {
            AcademicGrade = newGrade;
            Console.WriteLine("Grade updated for " + FullName + " (Enrollment Number: " + EnrollmentNumber + ") to " + AcademicGrade);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Learner learner1 = new Learner("Emily Carter", "N101", "B");
            if (learner1 is Learner)
            {
                learner1.ShowLearnerDetails();
                learner1.ChangeGrade("B+");
                Console.WriteLine();
            }

            Learner learner2 = new Learner("Michael Brown", "N102", "A");
            if (learner2 is Learner)
            {
                learner2.ShowLearnerDetails();
                learner2.ChangeGrade("A+");
                Console.WriteLine();
            }

            Learner.ShowTotalStudents();
            Console.ReadLine();
        }
    }
}

