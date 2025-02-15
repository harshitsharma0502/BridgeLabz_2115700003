using System;
using System.Text;

class WordSearchInSentences
{
    static void Main()
    {
        Console.Write("Enter the number of sentences: ");
        int size = int.Parse(Console.ReadLine());

        string[] sentences = new string[size];
        Console.WriteLine("Enter the sentences:");
        for (int i = 0; i < size; i++)
        {
            sentences[i] = Console.ReadLine();
        }

        Console.Write("Enter the word to search: ");
        string targetWord = Console.ReadLine();

        StringBuilder result = new StringBuilder();
        bool found = false;

        for (int i = 0; i < size; i++)
        {
            if (sentences[i].Contains(targetWord))
            {
                result.Append("Word found in sentence ").Append(i + 1).Append(": ").Append(sentences[i]).Append("\n");
                found = true;
                break; // Stops at the first occurrence
            }
        }

        if (!found)
            result.Append("Word not found in any sentence.");

        Console.WriteLine(result.ToString());
    }
}
