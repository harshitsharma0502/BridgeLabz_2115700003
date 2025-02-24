using System;

public class BankAccount
{
    private double balance;

    public BankAccount(double initialBalance = 0)
    {
        if (initialBalance < 0) throw new ArgumentException("Initial balance cannot be negative.");
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0) throw new ArgumentException("Deposit amount must be positive.");
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0) throw new ArgumentException("Withdrawal amount must be positive.");
        if (amount > balance) throw new InvalidOperationException("Insufficient funds.");
        balance -= amount;
    }

    public double GetBalance()
    {
        return balance;
    }
}


using NUnit.Framework;
using System;

[TestFixture]
public class BankAccountTests
{
    private BankAccount account;

    [SetUp]
    public void Setup()
    {
        account = new BankAccount(100); // Initial balance = 100
    }

    [Test]
    public void Deposit_ShouldIncreaseBalance()
    {
        account.Deposit(50);
        Assert.AreEqual(150, account.GetBalance());
    }

    [Test]
    public void Withdraw_ShouldDecreaseBalance()
    {
        account.Withdraw(40);
        Assert.AreEqual(60, account.GetBalance());
    }

    [Test]
    public void Withdraw_ShouldThrowException_WhenFundsAreInsufficient()
    {
        Assert.Throws<InvalidOperationException>(() => account.Withdraw(200));
    }

    [Test]
    public void Deposit_ShouldThrowException_ForNegativeOrZeroAmount()
    {
        Assert.Throws<ArgumentException>(() => account.Deposit(-10));
        Assert.Throws<ArgumentException>(() => account.Deposit(0));
    }

    [Test]
    public void Withdraw_ShouldThrowException_ForNegativeOrZeroAmount()
    {
        Assert.Throws<ArgumentException>(() => account.Withdraw(-10));
        Assert.Throws<ArgumentException>(() => account.Withdraw(0));
    }

    [Test]
    public void GetBalance_ShouldReturnCorrectBalance()
    {
        Assert.AreEqual(100, account.GetBalance());
    }
}