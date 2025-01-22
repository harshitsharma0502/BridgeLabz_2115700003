using System;

class Program {
    public static void Main(string[] args) {
        Console.Write("Enter value for a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter value for b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter value for c: ");
        double c = double.Parse(Console.ReadLine());

        double result1 = a + b * c;
        double result2 = a * b + c;
        double result3 = c + a / b;

        Console.WriteLine("The result of Double Operations{0}, {1}, and {2}", result1, result2, result3);
    }
}
