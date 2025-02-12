using System;

namespace ShoppingCartSystem
{
    public class Item
    {
        static double CurrentDiscount;
        static int ItemCounter;

        readonly string ItemCode;
        string ItemName;
        double ItemPrice;
        int StockQuantity;

        static Item()
        {
            CurrentDiscount = 0.0;
            ItemCounter = 0;
        }

        public Item(string itemName, double itemPrice, int stockQuantity)
        {
            this.ItemName = itemName;
            this.ItemPrice = itemPrice;
            this.StockQuantity = stockQuantity;
            this.ItemCode = "I" + (++ItemCounter).ToString("D4");
        }

        public static void SetDiscount(double newDiscount)
        {
            CurrentDiscount = newDiscount;
            Console.WriteLine("Discount has been updated to " + CurrentDiscount + "%");
        }

        public void ShowItemDetails()
        {
            Console.WriteLine("Item Code: " + ItemCode);
            Console.WriteLine("Item Name: " + ItemName);
            Console.WriteLine("Price: $" + ItemPrice);
            Console.WriteLine("Stock Quantity: " + StockQuantity);
            Console.WriteLine("Discount: " + CurrentDiscount + "%");
        }

        public double CalculateFinalCost()
        {
            double totalCost = ItemPrice * StockQuantity;
            return totalCost - (totalCost * CurrentDiscount / 100);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Item.SetDiscount(15.0);

            Item item1 = new Item("Smartphone", 700.00, 1);
            if (item1 is Item)
            {
                item1.ShowItemDetails();
                Console.WriteLine("Final Cost: $" + item1.CalculateFinalCost() + "\n");
            }

            Item item2 = new Item("Wireless Mouse", 50.00, 5);
            if (item2 is Item)
            {
                item2.ShowItemDetails();
                Console.WriteLine("Final Cost: $" + item2.CalculateFinalCost() + "\n");
            }

            Console.ReadLine();
        }
    }
}