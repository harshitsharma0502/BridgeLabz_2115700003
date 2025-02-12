using System;

public class Book
{
    public string title;
    public string author;
    public string genre;
    public int bookId;
    public bool isAvailable;
    public Book next;
    public Book prev;

    public Book(string title, string author, string genre, int bookId, bool isAvailable = true)
    {
        this.title = title;
        this.author = author;
        this.genre = genre;
        this.bookId = bookId;
        this.isAvailable = isAvailable;
        this.next = null;
        this.prev = null;
    }
}

public class Library
{
    private Book head;
    private Book tail;

    public void AddBookAtBeginning(Book newBook)
    {
        if (head == null)
        {
            head = tail = newBook;
        }
        else
        {
            newBook.next = head;
            head.prev = newBook;
            head = newBook;
        }
        Console.WriteLine("Book added at the beginning.");
    }

    public void AddBookAtEnd(Book book)
    {
        if (tail == null)
        {
            head = tail = book;
        }
        else
        {
            tail.next = book;
            book.prev = tail;
            tail = book;
        }
        Console.WriteLine("Book added at the end.");
    }

    public void AddBookAtPosition(Book book, int position)
    {
        if (position <= 1)
        {
            AddBookAtBeginning(book);
            return;
        }

        Book temp = head;
        for (int i = 1; temp != null && i < position - 1; i++)
        {
            temp = temp.next;
        }

        if (temp == null || temp.next == null)
        {
            AddBookAtEnd(book);
        }
        else
        {
            book.next = temp.next;
            book.prev = temp;
            temp.next.prev = book;
            temp.next = book;
            Console.WriteLine("Book added at position " + position);
        }
    }

    public void RemoveBookById(int id)
    {
        if (head == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        Book temp = head;

        if (temp.bookId == id)
        {
            head = head.next;
            if (head != null)
                head.prev = null;
            else
                tail = null;
            Console.WriteLine("Book removed successfully.");
            return;
        }

        while (temp != null && temp.bookId != id)
        {
            temp = temp.next;
        }

        if (temp == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        if (temp.next != null)
            temp.next.prev = temp.prev;

        if (temp.prev != null)
            temp.prev.next = temp.next;

        if (temp == tail)
            tail = temp.prev;

        Console.WriteLine("Book removed successfully.");
    }

    public void SearchBookById(int id)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.bookId == id)
            {
                Console.WriteLine($"Book found: {temp.title}, Author: {temp.author}, Genre: {temp.genre}, Availability: {temp.isAvailable}");
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Book not found.");
    }

    public void SearchBookByAuthor(string author)
    {
        if (author == null)
        {
            Console.WriteLine("Author name cannot be null.");
            return;
        }

        Book temp = head;
        while (temp != null)
        {
            if (temp.author == author)
            {
                Console.WriteLine($"Book found: {temp.title}, Author: {temp.author}, Genre: {temp.genre}, Availability: {temp.isAvailable}");
                return;
            }
            temp = temp.next;
        }

        Console.WriteLine("Book not found.");
    }

    public void UpdateAvailabilityStatus(int id)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.bookId == id)
            {
                temp.isAvailable = !temp.isAvailable;
                Console.WriteLine("Availability status updated successfully.");
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Book not found.");
    }

    public void CountAllBooks()
    {
        int count = 0;
        Book temp = head;
        while (temp != null)
        {
            count++;
            temp = temp.next;
        }
        Console.WriteLine("Total number of books in the library: " + count);
    }

    public void DisplayBooks()
    {
        if (head == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        Book temp = head;
        Console.WriteLine("Library Books:");
        while (temp != null)
        {
            Console.WriteLine($"Title: {temp.title}, Author: {temp.author}, Genre: {temp.genre}, Book ID: {temp.bookId}, Available: {temp.isAvailable}");
            temp = temp.next;
        }
    }

    public void DisplayBookInReverse()
    {
        if (tail == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }
        Book temp = tail;
        Console.WriteLine("Library Books in Reverse:");
        while (temp != null)
        {
            Console.WriteLine($"Title: {temp.title}, Author: {temp.author}, Genre: {temp.genre}, Book ID: {temp.bookId}, Available: {temp.isAvailable}");
            temp = temp.prev;
        }
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();

        library.AddBookAtBeginning(new Book("The Great Gatsby", "F. Scott Fitzgerald", "Fiction", 101));
        library.AddBookAtEnd(new Book("1984", "George Orwell", "Dystopian", 102));
        library.AddBookAtEnd(new Book("To Kill a Mockingbird", "Harper Lee", "Classic", 103));
        library.AddBookAtPosition(new Book("Moby Dick", "Herman Melville", "Adventure", 104), 2);

        library.DisplayBooks();

        Console.WriteLine("\nSearching for Book ID 102:");
        library.SearchBookById(102);

        Console.WriteLine("\nSearching for books by Harper Lee:");
        library.SearchBookByAuthor("Harper Lee");

        Console.WriteLine("\nRemoving book with ID 103:");
        library.RemoveBookById(103);
        library.DisplayBooks();

        Console.WriteLine("\nUpdating availability of Book ID 101:");
        library.UpdateAvailabilityStatus(101);
        library.DisplayBooks();

        library.CountAllBooks();

        library.DisplayBookInReverse();
    }
}
