using System;

class AlphabetChecker
{
    public static void Main()
    {
        // Input an integer value
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Initialize counters for vowels and consonants
        int vowelCount = 0;
        int consonantCount = 0;

        // Loop through each character in the input string
        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];

            // Check if the character is a letter 
            if (currentChar >= 'a' && currentChar <= 'z')
            {
                // Check if the letter is a vowel
                if (currentChar == 'a' || currentChar == 'e' || currentChar == 'i' ||
                    currentChar == 'o' || currentChar == 'u' || currentChar == 'A' || currentChar == 'E' || currentChar == 'I' ||
                    currentChar == 'O' || currentChar == 'U')
                {
                    vowelCount++;  
                }
                else
                {
                    consonantCount++;  
                }
            }
        }

        // Output the results
        Console.WriteLine("Vowels: " + vowelCount);
        Console.WriteLine("Consonants: " + consonantCount);
    }
}
