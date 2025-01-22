using System;
class PurchaseCalculator {
    public static void Main(string[] args) {
        // Take user input for unit price and quantity
        Console.Write("Enter the unit price: ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        // Calculate total price
        double totalPrice = unitPrice * quantity;

        // Display the result
        Console.WriteLine("The total purchase price is INR " + totalPrice + " if the quantity is " + quantity + " and unit price is INR " + unitPrice);
    }
}
