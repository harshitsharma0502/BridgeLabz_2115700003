using System;
using System.Text;

class EfficientStringConcatenation
{
    static void Main()
    {
        // Ask the user for the number of strings
        Console.Write("Enter the number of strings: ");
        int count = Convert.ToInt32(Console.ReadLine());

        // StringBuilder to efficiently concatenate strings
        StringBuilder sb = new StringBuilder();

        // Loop to take multiple string inputs from the user
        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter string " + (i + 1) + ": ");
            string input = Console.ReadLine();
            sb.Append(input); // Append each string to StringBuilder
        }

        // Print the final concatenated string
        Console.WriteLine("Concatenated String: " + sb.ToString());
    }
}
