using System;
namespace OOPsInCsharp
{
    public class AccountManagementSystem
    {
        static string bankTitle;
        static int totalCustomers;
        string customerName;
        readonly string customerAccountNumber;

        static AccountManagementSystem()
        {
            bankTitle = "Reserve Bank of India";
            totalCustomers = 0;
        }

        public static void DisplayTotalCustomers()
        {
            Console.WriteLine("Total Customers: " + totalCustomers);
        }

        public AccountManagementSystem(string customerName, string customerAccountNumber)
        {
            this.customerName = customerName;
            this.customerAccountNumber = customerAccountNumber;
            totalCustomers++;
        }
        public void ShowAccountDetails()
        {
            Console.WriteLine("Bank Title: " + bankTitle);
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Account Number: " + customerAccountNumber);
        }
    }
    internal class StarterProgram
    {
        static void Main(string[] args)
        {
            AccountManagementSystem customer1 = new AccountManagementSystem("Harshit Sharma", "4861287436");

            if (customer1 is AccountManagementSystem)
            {
                customer1.ShowAccountDetails();
            }

            AccountManagementSystem customer2 = new AccountManagementSystem("Tony", "6374744233");

            if (customer2 is AccountManagementSystem)
            {
                customer2.ShowAccountDetails();
            }

            AccountManagementSystem.DisplayTotalCustomers();
        }
    }
}