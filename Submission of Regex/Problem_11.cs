using System;
using System.Text.RegularExpressions;

class Program
{
    public static bool IsValidCreditCard(string cardNumber)
    {
        cardNumber = cardNumber.Replace(" ", "").Replace("-", "");

        string visaPattern = @"^4\d{15}$";
        string masterCardPattern = @"^5[1-5]\d{14}$";

        return Regex.IsMatch(cardNumber, visaPattern) || Regex.IsMatch(cardNumber, masterCardPattern);
    }

    static void Main()
    {
        string[] testCards = { "4111111111111111", "5105105105105100", "1234567812345678", "400012341234123", "5222222222222222" };

        foreach (string card in testCards)
        {
            Console.WriteLine($"{card}  {(IsValidCreditCard(card) ? "Valid" : "Invalid")}");
        }
    }
}