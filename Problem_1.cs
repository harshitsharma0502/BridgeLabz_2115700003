using System;
using System.Text;

class StringReverser // A name that describes what this class does
{
    static void Main()
    {
        // Ask the user for input
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Use StringBuilder to store the string (since it's mutable)
        StringBuilder sb = new StringBuilder(input);

        // Pointers at both ends of the string
        int left = 0, right = sb.Length - 1;

        // Swap characters until we reach the middle
        while (left < right)
        {
            char temp = sb[left];   // Temporarily store the left character
            sb[left] = sb[right];   // Move the right character to the left
            sb[right] = temp;       // Move the stored left character to the right

            // Move pointers towards the center
            left++;
            right--;
        }

        // Print the reversed string
        Console.WriteLine("Reversed string: " + sb.ToString());
    }
}
