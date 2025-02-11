using System;
using System.Collections.Generic;

public abstract class Product
{
    private int productID;
    private string name;
    private double price;
    private double discount;

    public int ProductId
    {
        get { return productID; }
        set { productID = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public double Discount
    {
        get { return discount; }
        set { discount = value; }
    }

    public Product(int productID, string name, double price, double discount)
    {
        this.productID = productID;
        this.name = name;
        this.price = price;
        this.discount = discount;
    }

    public abstract double CalculateDiscount();
    public abstract void DisplayDetails();

}

public interface ITaxable
{
    public double CalculateTax();
    public void GetTaxDetails();
}

public class Electronics : Product, ITaxable
{
    private const double taxRate = 5;

    public double TaxRate
    {
        get { return taxRate; }
    }

    public Electronics(int productID, string name, double price, double discount) : base(productID, name, price, discount)
    {
    }

    public override double CalculateDiscount()
    {
        double discountAmount = Price * Discount / 100;
        return discountAmount;
    }

    public double CalculateTax()
    {
        double tax = Price * TaxRate / 100;
        Price += tax;
        return tax;
    }

    public double CalculateTotalPrice()
    {
        return Price - CalculateDiscount() + CalculateTax();
    }

    public void GetTaxDetails()
    {
        Console.WriteLine("Tax Rate: " + TaxRate + "%");
        Console.WriteLine("Tax Amount: " + CalculateTax());
    }

    public override void DisplayDetails()
    {
        Console.WriteLine("Product ID: " + ProductId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Discount: " + Discount + "%");
        Console.WriteLine("Total Price: " + CalculateTotalPrice());
    }

}

public class Groceries : Product
{
    public Groceries(int productID, string name, double price, double discount) : base(productID, name, price, discount)
    {
    }

    public override double CalculateDiscount()
    {
        double discountAmount = Price * Discount / 100;
        return discountAmount;
    }

    public double CalculateTotalPrice()
    {
        return Price - CalculateDiscount();
    }
    public override void DisplayDetails()
    {
        Console.WriteLine("Product ID: " + ProductId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Discount: " + Discount + "%");
        Console.WriteLine("Total Price: " + CalculateTotalPrice());
    }
}

public class Clothing : Product, ITaxable
{
    private const double taxRate = 2;

    public double TaxRate
    {
        get { return taxRate; }
    }

    public Clothing(int productID, string name, double price, double discount) : base(productID, name, price, discount)
    {
    }

    public override double CalculateDiscount()
    {
        double discountAmount = Price * Discount / 100;
        return discountAmount;
    }

    public double CalculateTax()
    {
        double tax = Price * TaxRate / 100;
        Price += tax;
        return tax;
    }

    public double CalculateTotalPrice()
    {
        return Price - CalculateDiscount() + CalculateTax();
    }

    public void GetTaxDetails()
    {
        Console.WriteLine("Tax Rate: " + TaxRate + "%");
        Console.WriteLine("Tax Amount: " + CalculateTax());
    }

    public override void DisplayDetails()
    {
        Console.WriteLine("Product ID: " + ProductId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Discount: " + Discount + "%");
        Console.WriteLine("Total Price: " + CalculateTotalPrice());
    }
}

public class Program
{
    public static void Main()
    {
        List<Product> products = new List<Product>();

        Electronics electronics = new Electronics(101, "Laptop", 45000, 10);

        Groceries groceries = new Groceries(201, "Rice", 50, 5);

        Clothing clothing = new Clothing(301, "Shirt", 500, 20);

        products.Add(electronics);
        products.Add(groceries);
        products.Add(clothing);

        foreach (Product product in products)
        {
            product.DisplayDetails();

            if (product is ITaxable taxableProduct)
            {
                taxableProduct.GetTaxDetails();
            }

            Console.WriteLine();
        }

    }
}