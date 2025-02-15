using System;
using System.IO;

class ReadFileLineByLine
{
    static void Main()
    {
        // Ask the user for the file path
        Console.Write("Enter the file path: ");
        string filePath = Console.ReadLine();

        // Check if the file exists before attempting to read
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Error: File not found.");
            return;
        }

        // Open file using StreamReader
        StreamReader sr = new StreamReader(filePath);

        // Read and print each line manually
        while (true)
        {
            string line = sr.ReadLine(); // Read next line
            if (line == null) // Check for end of file
                break;

            Console.WriteLine(line); // Print the line
        }

        // Close the StreamReader to release resources
        sr.Close();
    }
}
