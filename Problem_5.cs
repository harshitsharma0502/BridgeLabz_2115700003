using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            using (StreamReader reader = new StreamReader("C:\\Users\\HP\\Desktop\\Capgemini__Harshit\\BridgeLabz_2115700003\\data.txt"))
            {
                string firstLine = reader.ReadLine();
                Console.WriteLine(firstLine);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading file");
        }
    }
}
