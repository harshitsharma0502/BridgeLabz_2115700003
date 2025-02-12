using System;

namespace LibraryManagementSystem
{
    internal class Book
    {
        static string libraryLocation;
        string author;
        string bookTitle;
        readonly string uniqueISBN;

        static Book()
        {
            libraryLocation = "Central City Library";
        }

        public static void ShowLibraryLocation()
        {
            Console.WriteLine("Library Location: " + libraryLocation);
        }

        public Book(string author, string bookTitle, string uniqueISBN)
        {
            this.author = author;
            this.bookTitle = bookTitle;
            this.uniqueISBN = uniqueISBN;
        }

        public void ShowBookInfo()
        {
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Book Title: " + bookTitle);
            Console.WriteLine("ISBN: " + uniqueISBN);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book.ShowLibraryLocation();
            Book book = new Book("J.K. Rowling", "Harry Potter and the Sorcerer's Stone", "9780747532743");

            if (book is Book)
            {
                book.ShowBookInfo();
            }
        }
    }
}
