using System;

class SumUntilZeroOrNegative
{
    static void Main()
    {
        double total = 0.0;
        double number;

        while (true)
        {
            Console.Write("Enter a number (0 or a negative number to stop): ");
            number = double.Parse(Console.ReadLine());

            if (number <= 0)
            {
                break; 
            }

            total += number;
        }


        Console.WriteLine("The total sum is: " + total);
    }
}
