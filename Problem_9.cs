using System;

class DiscountCalculatorWithInput {
    public static void Main(string[] args) {
        // Take user input for fee and discount percentage
        Console.Write("Enter the course fee: ");
        double fee = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the discount percentage: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        // Calculate discount amount and final fee
        double discountAmount = (fee * discountPercent) / 100;
        double finalFee = fee - discountAmount;

        // Display the result
        Console.WriteLine("The discount amount is INR " + discountAmount + " and the final discounted fee is INR " + finalFee);
    }
}
