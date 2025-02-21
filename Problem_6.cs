using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string inputFilePath = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment28\\Text1.txt";
        string outputFilePath = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment28\\output.txt";

        try
        {
            using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            using (BufferedStream bufferedInput = new BufferedStream(inputStream))
            using (StreamReader reader = new StreamReader(bufferedInput, Encoding.UTF8))
            using (FileStream outputStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
            using (BufferedStream bufferedOutput = new BufferedStream(outputStream))
            using (StreamWriter writer = new StreamWriter(bufferedOutput, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line.ToLower());
                }
            }
            Console.WriteLine("File conversion completed successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
