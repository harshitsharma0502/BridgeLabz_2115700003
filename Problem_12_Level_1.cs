using System;

class SumOfNaturalNumbers
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Please enter a valid natural number greater than 0.");
            return;
        }

        int formulaSum = n * (n + 1) / 2;

        int loopSum = 0;
        int i = 1;
        while (i <= n)
        {
            loopSum += i;
            i++;
        }

        Console.WriteLine("Sum using formula: " + formulaSum);
        Console.WriteLine("Sum using while loop: " + loopSum);

        // Compare the result
        if (formulaSum == loopSum)
        {
            Console.WriteLine("Both computations are correct!");
        }
        else
        {
            Console.WriteLine("There is a discrepancy between the computations.");
        }
    }
}
