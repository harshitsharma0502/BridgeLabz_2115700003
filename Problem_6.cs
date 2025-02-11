using System;
using System.Collections.Generic;

// Abstract class FoodItem
public abstract class FoodItem
{
    public string ItemName { get; private set; }
    public double Price { get; private set; }
    public int Quantity { get; private set; }

    protected FoodItem(string itemName, double price, int quantity)
    {
        ItemName = itemName;
        Price = price;
        Quantity = quantity;
    }

    public abstract double CalculateTotalPrice();

    public string GetItemDetails()
    {
        return $"Item: {ItemName}, Price: ${Price}, Quantity: {Quantity}";
    }
}

// Interface for discountable items
public interface IDiscountable
{
    void ApplyDiscount(double discountPercentage);
    string GetDiscountDetails();
}

// VegItem subclass
public class VegItem : FoodItem, IDiscountable
{
    private double discount;

    public VegItem(string itemName, double price, int quantity)
        : base(itemName, price, quantity)
    {
    }

    public override double CalculateTotalPrice()
    {
        return Price * Quantity * 0.9; // 10% discount for veg items
    }

    public void ApplyDiscount(double discountPercentage)
    {
        discount = (Price * Quantity) * (discountPercentage / 100);
        Console.WriteLine($"Discount of ${discount} applied to {ItemName}.");
    }

    public string GetDiscountDetails()
    {
        return $"Discount Applied: ${discount}";
    }
}

// NonVegItem subclass
public class NonVegItem : FoodItem, IDiscountable
{
    private double additionalCharge;
    private double discount;

    public NonVegItem(string itemName, double price, int quantity)
        : base(itemName, price, quantity)
    {
        additionalCharge = 2.5; // Additional charge per item for non-veg
    }

    public override double CalculateTotalPrice()
    {
        return (Price + additionalCharge) * Quantity;
    }

    public void ApplyDiscount(double discountPercentage)
    {
        discount = (Price * Quantity) * (discountPercentage / 100);
        Console.WriteLine($"Discount of ${discount} applied to {ItemName}.");
    }

    public string GetDiscountDetails()
    {
        return $"Discount Applied: ${discount}";
    }
}

// Main program to demonstrate polymorphism
public class Program
{
    public static void Main(string[] args)
    {
        List<FoodItem> foodItems = new List<FoodItem>
        {
            new VegItem("Vegetable Sandwich", 5.0, 3),
            new NonVegItem("Chicken Burger", 7.5, 2)
        };

        foreach (var item in foodItems)
        {
            Console.WriteLine(item.GetItemDetails());
            Console.WriteLine($"Total Price: ${item.CalculateTotalPrice()}");

            if (item is IDiscountable discountableItem)
            {
                discountableItem.ApplyDiscount(10); // Apply 10% discount
                Console.WriteLine(discountableItem.GetDiscountDetails());
            }

            Console.WriteLine();
        }
    }
}
