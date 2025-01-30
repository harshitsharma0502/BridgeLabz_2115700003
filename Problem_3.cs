using System;

class PalindromeCheck
{
    public static void Main(string[] args)
    {
        // Input an String
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Reverse the string 
        string reversedString = "";

        // Loop through the input string in reverse order
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversedString += input[i];  // Append each character to the reversed string
        }

        if (reversedString == input)
			Console.WriteLine( input + " is a palindrome");
		else
			Console.WriteLine( input + " is a not palindrome");
    }
}
