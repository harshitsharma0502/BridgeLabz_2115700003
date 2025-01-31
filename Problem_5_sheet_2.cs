using System;
using System.Linq;

namespace PalindromeChecker
{
    class Palindrome
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check if it is a palindrome:");
            string input = GetInput("Please enter a string: ");
            bool isPalindrome = CheckPalindrome(input);
            DisplayResult(isPalindrome);
        }

        static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        static bool CheckPalindrome(string input)
        {
            // Remove non-alphanumeric characters and convert to lowercase
            string cleanedInput = new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();

            // Check if the cleaned string is a palindrome
            char[] charArray = cleanedInput.ToCharArray();
            string reversedString = new string(charArray.Reverse().ToArray());

            return cleanedInput == reversedString;
        }

        static void DisplayResult(bool isPalindrome)
        {
            if (isPalindrome)
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }
        }
    }
}