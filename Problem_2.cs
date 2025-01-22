using System;

class Program {
    public static void Main(string[] args) {
        Console.Write("Enter value for a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter value for b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter value for c: ");
        int c = int.Parse(Console.ReadLine());

        int result1 = a + b * c;
        int result2 = a * b + c;
        int result3 = c + a / b;
        int result4 = a % b + c;

        Console.WriteLine("The result of Int Operations are {0}, {1}, {2}, and {3}", result1, result2, result3, result4);
    }
}
