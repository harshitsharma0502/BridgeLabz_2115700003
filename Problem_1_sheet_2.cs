using System;

namespace NumberGuessingGame
{
    class GuessNumbers
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Think of a number between 1 and 100. I'll try to guess it!");
            GuessNumber();
        }

        public static void GuessNumber()
        {
            int lowerBound = 1;
            int upperBound = 100;
            int guessCount = 0;

            while (true)
            {
                int guess = GenerateGuess(lowerBound, upperBound);
                guessCount++;
                Console.WriteLine("Is your number " + guess + "? (Enter 'high', 'low', or 'correct')");

                string feedback = GetFeedback();

                if (feedback == "correct")
                {
                    Console.WriteLine("I guessed your number in " + guessCount + " guesses!");
                    break;
                }
                else if (feedback == "high")
                {
                    upperBound = guess - 1;
                }
                else if (feedback == "low")
                {
                    lowerBound = guess + 1;
                }
            }
        }

        public static int GenerateGuess(int lowerBound, int upperBound)
        {
            Random random = new Random();
            return random.Next(lowerBound, upperBound + 1);
        }

        public static string GetFeedback()
        {
            string feedback;
            do
            {
                feedback = Console.ReadLine().ToLower();
                if (feedback != "high" && feedback != "low" && feedback != "correct")
                {
                    Console.WriteLine("Invalid input. Please enter 'high', 'low', or 'correct'.");
                }
            } while (feedback != "high" && feedback != "low" && feedback != "correct");

            return feedback;
        }
    }
}