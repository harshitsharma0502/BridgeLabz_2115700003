using System;

public abstract class Bank
{
    private int accountNumber;
    private string accountHolder;
    private double balance;
    public int AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }
    public string AccountHolder
    {
        get { return accountHolder; }
        set { accountHolder = value; }
    }
    public double Balance
    {
        get { return balance; }
        set { balance = value; }
    }
    public Bank(int accountNumber, string accountHolder, double balance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }
    public abstract double CalculateInterest();
    public void deposit(double amount)
    {
        balance += amount;
    }
    public void withdraw(double amount)
    {
        balance -= amount;
    }
    public void displayDetails()
    {
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Account Holder: {accountHolder}");
        Console.WriteLine($"Balance: {balance}");
    }
}
public interface ILonable
{
    void ApplyForLoan(double Amount);
    double CalculateLoanEligibility();
}
public class SavingsAccount : Bank, ILonable
{
    private double interestRate;

    public SavingsAccount(int accountNumber, string holderName, double initialBalance, double interestRate)
        : base(accountNumber, holderName, initialBalance)
    {
        this.interestRate = interestRate;
    }

    public override double CalculateInterest()
    {
        return Balance * interestRate;
    }

    public void ApplyForLoan(double loanAmount)
    {
        Console.WriteLine($"Applying for a loan of ${loanAmount} for Savings Account {AccountNumber}.");
    }

    public double CalculateLoanEligibility()
    {
        return Balance * 0.5; // Loan eligibility is 50% of the balance
    }
}
public class CurrentAccount : Bank, ILonable
{
    private double interestRate;
    public CurrentAccount(int accountNumber, string holderName, double initialBalance, double interestRate)
        : base(accountNumber, holderName, initialBalance)
    {
        this.interestRate = interestRate;
    }
    public override double CalculateInterest()
    {
        return Balance * interestRate;
    }
    public void ApplyForLoan(double loanAmount)
    {
        Console.WriteLine($"Applying for a loan of ${loanAmount} for Current Account {AccountNumber}.");
    }
    public double CalculateLoanEligibility()
    {
        return Balance * 0.75; // Loan eligibility is 75% of the balance
    }
}
class Program
{
    static void Main(string[] args)
    {
        SavingsAccount savingsAccount = new SavingsAccount(001, "Alice", 1000, 0.02);
        CurrentAccount currentAccount = new CurrentAccount(002, "Bob", 2000, 0.03);
        savingsAccount.deposit(500);
        savingsAccount.withdraw(200);
        savingsAccount.displayDetails();
        Console.WriteLine($"Interest: {savingsAccount.CalculateInterest()}");
        currentAccount.deposit(1000);
        currentAccount.withdraw(500);
        currentAccount.displayDetails();
        Console.WriteLine($"Interest: {currentAccount.CalculateInterest()}");
        savingsAccount.ApplyForLoan(5000);
        Console.WriteLine($"Loan Eligibility: {savingsAccount.CalculateLoanEligibility()}");
        currentAccount.ApplyForLoan(10000);
        Console.WriteLine($"Loan Eligibility: {currentAccount.CalculateLoanEligibility()}");
    }
}