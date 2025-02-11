using System;
using System.Collections.Generic;

// Abstract class LibraryItem
public abstract class LibraryItem
{
    public string ItemId { get; private set; }
    public string Title { get; private set; }
    public string Author { get; private set; }

    protected LibraryItem(string itemId, string title, string author)
    {
        ItemId = itemId;
        Title = title;
        Author = author;
    }

    public abstract int GetLoanDuration();

    public string GetItemDetails()
    {
        return $"ID: {ItemId}, Title: {Title}, Author: {Author}";
    }
}

// Interface for reservable items
public interface IReservable
{
    void ReserveItem();
    bool CheckAvailability();
}

// Book subclass
public class Book : LibraryItem, IReservable
{
    private bool isAvailable;

    public Book(string itemId, string title, string author)
        : base(itemId, title, author)
    {
        isAvailable = true;
    }

    public override int GetLoanDuration()
    {
        return 14; // Books can be loaned for 14 days
    }

    public void ReserveItem()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine("Book has been reserved.");
        }
        else
        {
            Console.WriteLine("Book is already reserved.");
        }
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}

// Magazine subclass
public class Magazine : LibraryItem
{
    public Magazine(string itemId, string title, string author)
        : base(itemId, title, author)
    {
    }

    public override int GetLoanDuration()
    {
        return 7; // Magazines can be loaned for 7 days
    }
}

// DVD subclass
public class DVD : LibraryItem, IReservable
{
    private bool isAvailable;

    public DVD(string itemId, string title, string author)
        : base(itemId, title, author)
    {
        isAvailable = true;
    }

    public override int GetLoanDuration()
    {
        return 3; // DVDs can be loaned for 3 days
    }

    public void ReserveItem()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine("DVD has been reserved.");
        }
        else
        {
            Console.WriteLine("DVD is already reserved.");
        }
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}

// Main program to demonstrate polymorphism
public class Program
{
    public static void Main(string[] args)
    {
        List<LibraryItem> libraryItems = new List<LibraryItem>
        {
            new Book("B001", "C# Programming", "John Doe"),
            new Magazine("M001", "Tech Weekly", "Jane Smith"),
            new DVD("D001", "Inception", "Christopher Nolan")
        };

        foreach (var item in libraryItems)
        {
            Console.WriteLine(item.GetItemDetails());
            Console.WriteLine($"Loan Duration: {item.GetLoanDuration()} days");

            if (item is IReservable reservableItem)
            {
                Console.WriteLine($"Availability: {(reservableItem.CheckAvailability() ? "Available" : "Not Available")}");
                reservableItem.ReserveItem();
                Console.WriteLine($"Availability after reservation: {(reservableItem.CheckAvailability() ? "Available" : "Not Available")}");
            }

            Console.WriteLine();
        }
    }
}
