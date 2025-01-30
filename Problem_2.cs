using System;

class ReverseString
{
    public static void Main(string[] args)
    {
        // Input an integer value
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Reverse the string 
        string reversedString = "";

        // Loop through the input string in reverse order
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversedString += input[i];  // Append each character to the reversed string
        }

        // Output the reversed string
        Console.WriteLine("Reversed string: " + reversedString);
    }
}
