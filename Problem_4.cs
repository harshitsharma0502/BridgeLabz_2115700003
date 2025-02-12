using System;

namespace LibraryManagement
{
   public class Book
   {
       public string Title { get; set; }
       public int PublicationYear { get; set; }

       public Book(string title, int publicationYear)
       {
           Title = title;
           PublicationYear = publicationYear;
       }

       public virtual void DisplayInfo()
       {
           Console.WriteLine($"Book Title: {Title}, Publication Year: {PublicationYear}");
       }
   }

   public class Author : Book
   {
       public string Name { get; set; }
       public string Bio { get; set; }

       public Author(string title, int publicationYear, string name, string bio) : base(title, publicationYear)
       {
           Name = name;
           Bio = bio;
       }
       public override void DisplayInfo()
       {
           base.DisplayInfo();
           Console.WriteLine($"Author: {Name}, Bio: {Bio}");
       }
   }
   class Program
   {
       static void Main(string[] args)
       {
           Author author = new Author("C# Programming Guide", 2023, "John Doe", "Expert in software development with over 10 years of experience.");
           author.DisplayInfo();
       }
   }
}
