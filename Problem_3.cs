using System;

namespace EmployeeManagementSystem
{
    public class StaffMember
    {
        static string OrganizationName;
        static int StaffCount;

        string FullName;
        readonly string EmployeeCode;
        string JobTitle;

        static StaffMember()
        {
            OrganizationName = "Innovative Solutions Ltd.";
            StaffCount = 0;
        }

        public StaffMember(string fullName, string employeeCode, string jobTitle)
        {
            this.FullName = fullName;
            this.EmployeeCode = employeeCode;
            this.JobTitle = jobTitle;
            StaffCount++;
        }

        public static void ShowTotalStaffCount()
        {
            Console.WriteLine("Total Staff Members: " + StaffCount);
        }

        public void ShowStaffDetails()
        {
            Console.WriteLine("Organization Name: " + OrganizationName);
            Console.WriteLine("Staff Member Name: " + FullName);
            Console.WriteLine("Employee Code: " + EmployeeCode);
            Console.WriteLine("Job Title: " + JobTitle);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            StaffMember staff1 = new StaffMember("Alice Johnson", "S001", "HR Manager");
            if (staff1 is StaffMember)
            {
                staff1.ShowStaffDetails();
            }

            Console.WriteLine();

            StaffMember staff2 = new StaffMember("Bob Lee", "S002", "Lead Developer");
            if (staff2 is StaffMember)
            {
                staff2.ShowStaffDetails();
            }

            Console.WriteLine();

            StaffMember.ShowTotalStaffCount();

            Console.ReadLine();
        }
    }
}
