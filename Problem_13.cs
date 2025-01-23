using System;

class SumOfNaturalNumbers
{
    static void Main()
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
        for (int i = 1; i <= n; i++)
        {
            loopSum += i; 
        }

        Console.WriteLine("Sum using formula: " + formulaSum);
        Console.WriteLine("Sum using for loop: " + loopSum);

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
