using System;

public class Book
{
    public string ISBN;
    protected string Title;
    private string Author;

    public Book(string isbn, string title, string author)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
    }

    public string GetAuthor()
    {
        return Author;
    }

    public void SetAuthor(string author)
    {
        if (!string.IsNullOrWhiteSpace(author))
        {
            Author = author;
        }
        else
        {
            Console.WriteLine("Invalid author name.");
        }
    }

    public void DisplayBookDetails()
    {
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
    }
}

public class EBook : Book
{
    public double FileSizeInMB;

    public EBook(string isbn, string title, string author, double fileSizeInMB)
        : base(isbn, title, author)
    {
        FileSizeInMB = fileSizeInMB;
    }

    public void DisplayEBookDetails()
    {
        Console.WriteLine($"EBook ISBN: {ISBN}");
        Console.WriteLine($"EBook Title: {Title}");
        Console.WriteLine($"File Size: {FileSizeInMB} MB");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("123-456-789", "The Great Gatsby", "F. Scott Fitzgerald");
        book.DisplayBookDetails();
        book.SetAuthor("Fitzgerald");
        Console.WriteLine($"Updated Author: {book.GetAuthor()}");

        EBook eBook = new EBook("987-654-321", "Digital Marketing", "John Doe", 2.5);
        eBook.DisplayEBookDetails();
    }
}