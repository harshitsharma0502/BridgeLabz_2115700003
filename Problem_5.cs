using System;
class BookSystem
{
    string title;
    string author;
    int price;
    int availablity;
    public BookSystem(string title, string author, int price, int availablity)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        this.availablity = availablity;
    }
    public void  BorrowBook()
    {
        if (availablity > 0)
        {
            availablity--;
            Console.WriteLine("Book is available");
        }
        else
        {
            Console.WriteLine("Book is not available");
            
        }
    }
    public static void Main()
    {
        BookSystem b= new BookSystem("C#", "vedant", 100, 5);
        b.BorrowBook();

    }
}