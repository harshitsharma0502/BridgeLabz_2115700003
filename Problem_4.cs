using System;

class RemoveDuplicate
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string result = "";

        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];
            bool isDuplicate = false;

            // Check if the current character is already in the result string
            for (int j = 0; j < result.Length; j++)
            {
                if (result[j] == currentChar)
                {
                    isDuplicate = true;
                    break;
                }
            }

            // If the character is not a duplicate, add it to the result string
            if (!isDuplicate)
            {
                result += currentChar;
            }
        }

        Console.WriteLine("String after removing duplicates:"+result);
    }
}