using System;
public class BankAccount
{
    // Public property for account number
    public string AccountNumber { get; set; }
    
    // Protected property for account holder
    protected string AccountHolder { get; set; }
    
    // Private field for balance
    private decimal balance;

    // Constructor to initialize the account
    public BankAccount(string accountNumber, string accountHolder, decimal initialBalance = 0.0m)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        balance = initialBalance;
    }

    // Public method to access and modify balance
    public decimal GetBalance()
    {
        return balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }

    // Method to display account details
    public void DisplayAccountDetails()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Account Holder: {AccountHolder}");
        Console.WriteLine($"Balance: {balance:C}");
    }
}

public class SavingsAccount : BankAccount
{
    // Constructor for SavingsAccount subclass
    public SavingsAccount(string accountNumber, string accountHolder, decimal initialBalance = 0.0m)
        : base(accountNumber, accountHolder, initialBalance)
    {
    }

    // Method to demonstrate access to inherited properties
    public void DisplaySavingsAccountDetails()
    {
        Console.WriteLine($"Savings Account Number: {AccountNumber}");
        Console.WriteLine($"Account Holder: {AccountHolder}");
        // Cannot access private balance directly in subclass, so use GetBalance
        Console.WriteLine($"Balance: {GetBalance():C}");
    }
}

public class Program
{
    public static void Main()
    {
        // Creating a BankAccount
        BankAccount bankAccount = new BankAccount("123456789", "John Doe", 1000.0m);
        bankAccount.DisplayAccountDetails();
        bankAccount.Deposit(500.0m);
        bankAccount.Withdraw(200.0m);
        bankAccount.DisplayAccountDetails();

        // Creating a SavingsAccount
        SavingsAccount savingsAccount = new SavingsAccount("987654321", "Jane Smith", 2000.0m);
        savingsAccount.DisplaySavingsAccountDetails();
    }
}