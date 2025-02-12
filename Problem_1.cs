using System;

public class Book
{
 public string title;
 public string author;
 public int price;
//  paramterized Constructor
 public Book(string title, string author, int price)
 {
     this.title = title;
     this.author = author;
     this.price = price;
 }
 // default Constructor
public Book()
 {
     this.title = "Introduction dotnet";
     this.author = "vedant";
     this.price = 1000;
 }
    public static void Main(string[] args)
    {
         Book b1 = new Book("C# Programming", "vedant", 1500);
 Book b2 = new Book();
 Console.WriteLine("Title: " + b1.title + " Author: " + b1.author + " Price: " + b1.price);
 Console.WriteLine("Title: " + b2.title + " Author: " + b2.author + " Price: " + b2.price);
    }
}