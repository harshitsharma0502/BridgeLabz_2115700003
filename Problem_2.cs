using System;
using System.Text;

class RemoveDuplicates // Class name that reflects the purpose
{
    static void Main()
    {
        // Ask the user for input
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // StringBuilder to store the result without duplicates
        StringBuilder sb = new StringBuilder();
        
        // Boolean array to track seen characters
        bool[] seen = new bool[256]; 

        // Process each character in the input string
        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];

            // If the character is not seen before, add it to StringBuilder
            if (!seen[currentChar])
            {
                sb.Append(currentChar);
                seen[currentChar] = true; // Mark this character as seen
            }
        }

        // Print the final string without duplicates
        Console.WriteLine("String after removing duplicates: " + sb.ToString());
    }
}
