using System;
using System.IO;

class FileReader
{
    static void Main()
    {
        string filePath = "data.txt"; // File name

        try
        {
            // Attempt to read the file
            string content = File.ReadAllText(filePath);
            Console.WriteLine("File Content:\n" + content);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred while reading the file: " + ex.Message);
        }
    }
}
