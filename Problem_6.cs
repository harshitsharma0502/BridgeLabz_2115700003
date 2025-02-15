using System;
using System.IO; // Required for file handling

class WordCountInFile
{
    static void Main()
    {
        // Step 1: Ask the user for the file path
        Console.Write("Enter the file path: ");
        string filePath = Console.ReadLine();

        // Step 2: Check if the file exists
        if (!File.Exists(filePath))
        {
            Console.WriteLine("The file does not exist. Please check the path.");
            return; // Exit if the file is not found
        }

        // Step 3: Ask the user for the word to search
        Console.Write("Enter the word to search: ");
        string searchWord = Console.ReadLine();

        // Step 4: Open the file using StreamReader
        StreamReader sr = new StreamReader(filePath);
        int wordCount = 0; // Variable to count occurrences

        // Step 5: Read the file line by line and count occurrences
        while (true)
        {
            string line = sr.ReadLine(); // Read a line
            if (line == null) // Stop if the file ends
                break;

            // Step 6: Manually count occurrences of the word (without using built-in functions)
            int index = 0;
            while ((index = line.IndexOf(searchWord, index)) != -1)
            {
                wordCount++; // Found an occurrence
                index += searchWord.Length; // Move forward to avoid counting the same occurrence
            }
        }

        // Step 7: Close the file to release memory
        sr.Close();

        // Step 8: Display the result
        Console.WriteLine($"\n The word '{searchWord}' appears {wordCount} times in the file.");
    }
}
