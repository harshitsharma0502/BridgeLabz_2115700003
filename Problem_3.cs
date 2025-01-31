using System;
public class Book
{
    // Attributes
    private string title;
    private string author;
    private double price;

    // Constructor to initialize attributes
    public Book(string BookTitle, string BookAuthor, double BookPrice)
    {
        title = BookTitle;
        author = BookAuthor;
        price = BookPrice;
    }

    // Method to display book details
    public void DisplayDetails()
    {
        Console.WriteLine("Book Title: " + title);
        Console.WriteLine("Book Author: " + author);
        Console.WriteLine("Book Price: " + price);
    }
}

public class Problem_3
{
    public static void Main(string[] args)
    {
        // Taking input from the user
        Console.WriteLine("Enter book title:");
        string title = Console.ReadLine();
        Console.WriteLine("Enter book author:");
        string author = Console.ReadLine();
        Console.WriteLine("Enter book price:");
        double price = double.Parse(Console.ReadLine());

        // Create Book object
        Book book1 = new Book(title, author, price);

        // Display book details
        book1.DisplayDetails();
    }
}
