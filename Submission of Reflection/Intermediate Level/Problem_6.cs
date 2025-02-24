using System;

// Define a custom attribute
[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute
{
    public string Name { get; }
    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

// Apply the custom attribute to a class
[Author("John Doe")]
class SampleClass
{
    public void Display() => Console.WriteLine("SampleClass method executed.");
}

class Program
{
    static void Main()
    {
        Type type = typeof(SampleClass);

        // Get custom attributes
        object[] attributes = type.GetCustomAttributes(typeof(AuthorAttribute), false);

        if (attributes.Length > 0)
        {
            AuthorAttribute author = (AuthorAttribute)attributes[0];
            Console.WriteLine($"Author: {author.Name}");
        }
        else
        {
            Console.WriteLine("No Author attribute found.");
        }
    }
}
