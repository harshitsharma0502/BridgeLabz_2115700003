using System;

class DiscountCalculator {
    public static void Main(string[] args) {
        // Define the course fee and discount percentage
        double courseFee = 125000;
        double discountPercentage = 10;

        // Calculate discount amount and final fee
        double discountAmount = (courseFee * discountPercentage) / 100;
        double finalFee = courseFee - discountAmount;

        // Display the result
        Console.WriteLine("The discount amount is INR " + discountAmount + " and the final discounted fee is INR " + finalFee);
    }
}
