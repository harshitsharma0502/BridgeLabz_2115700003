using System;

public class Product
{
    // Instance variables
    public string ProductName;
    public decimal Price;

    // Class variable
    public static int TotalProducts;

    // Constructor
    public Product(string productName, decimal price)
    {
        ProductName = productName;
        Price = price;
        TotalProducts++;
    }

    // Instance method to display product details
    public void DisplayProductDetails()
    {
        Console.WriteLine($"Product Name: {ProductName}");
        Console.WriteLine($"Price: {Price:C}");
    }

    // Class method to display total number of products
    public static void DisplayTotalProducts()
    {
        Console.WriteLine($"Total Products: {TotalProducts}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating products
        Product product1 = new Product("Laptop", 1500.99m);
        Product product2 = new Product("Smartphone", 899.49m);
        Product product3 = new Product("Headphones", 199.99m);

        // Displaying details of each product
        Console.WriteLine("Product 1 Details:");
        product1.DisplayProductDetails();

        Console.WriteLine("\nProduct 2 Details:");
        product2.DisplayProductDetails();

        Console.WriteLine("\nProduct 3 Details:");
        product3.DisplayProductDetails();

        // Displaying total products
        Console.WriteLine("\nTotal Products:");
        Product.DisplayTotalProducts();
    }
}