using System;
public class BankAccount
{
   public string AccountNumber { get; set; }
   public double Balance { get; set; }

   public BankAccount(string accountNumber, double balance)
   {
       AccountNumber = accountNumber;
       Balance = balance;
   }

   public virtual void DisplayAccountType()
   {
       Console.WriteLine("Generic Bank Account");
   }

   public void DisplayBalance()
   {
       Console.WriteLine($"Account Number: {AccountNumber}, Balance: ${Balance}");
   }
}

public class SavingsAccount : BankAccount
{
   public double InterestRate { get; set; }

   public SavingsAccount(string accountNumber, double balance, double interestRate)
       : base(accountNumber, balance)
   {
       InterestRate = interestRate;
   }

   public override void DisplayAccountType()
   {
       Console.WriteLine("Savings Account");
   }

   public void DisplayInterestRate()
   {
       Console.WriteLine($"Interest Rate: {InterestRate}%");
   }
}

public class CheckingAccount : BankAccount
{
   public double WithdrawalLimit { get; set; }

   public CheckingAccount(string accountNumber, double balance, double withdrawalLimit)
       : base(accountNumber, balance)
   {
       WithdrawalLimit = withdrawalLimit;
   }

   public override void DisplayAccountType()
   {
       Console.WriteLine("Checking Account");
   }

   public void DisplayWithdrawalLimit()
   {
       Console.WriteLine($"Withdrawal Limit: ${WithdrawalLimit}");
   }
}

public class FixedDepositAccount : BankAccount
{
   public DateTime MaturityDate { get; set; }

   public FixedDepositAccount(string accountNumber, double balance, DateTime maturityDate)
       : base(accountNumber, balance)
   {
       MaturityDate = maturityDate;
   }

   public override void DisplayAccountType()
   {
       Console.WriteLine("Fixed Deposit Account");
   }

   public void DisplayMaturityDate()
   {
       Console.WriteLine($"Maturity Date: {MaturityDate.ToShortDateString()}");
   }
}

class Program
{
   static void Main(string[] args)
   {
       BankAccount genericAccount = new BankAccount("123456", 5000);
       genericAccount.DisplayAccountType();
       genericAccount.DisplayBalance();
       SavingsAccount savings = new SavingsAccount("987654", 10000, 2.5);
       savings.DisplayAccountType();
       savings.DisplayBalance();
       savings.DisplayInterestRate();
       CheckingAccount checking = new CheckingAccount("456789", 2000, 1000);
       checking.DisplayAccountType();
       checking.DisplayBalance();
       checking.DisplayWithdrawalLimit();
       FixedDepositAccount fixedDeposit = new FixedDepositAccount("789123", 15000, DateTime.Now.AddYears(1));
       fixedDeposit.DisplayAccountType();
       fixedDeposit.DisplayBalance();
       fixedDeposit.DisplayMaturityDate();
   }
}