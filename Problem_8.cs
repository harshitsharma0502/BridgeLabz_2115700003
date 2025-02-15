using System;
using System.IO;

class WriteUserInputToFile
{
    static void Main()
    {
        Console.Write("Enter the file path to save input: ");
        string filePath = Console.ReadLine();

        Console.WriteLine("Enter text (type 'EXIT' to stop):");

        using (StreamWriter sw = new StreamWriter(filePath))
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input.Equals("EXIT", StringComparison.OrdinalIgnoreCase))
                    break;

                sw.WriteLine(input);
            }
        }

        Console.WriteLine("Data saved successfully!");
    }
}
