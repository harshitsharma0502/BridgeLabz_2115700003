using System;

class Program {
    public static void Main(string[] args) {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        // Swap logic
        int temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("The swapped numbers are {0} and {1}", num1, num2);
    }
}
