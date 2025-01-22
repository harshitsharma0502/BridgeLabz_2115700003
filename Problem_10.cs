using System;

class Program {
    public static void Main(string[] args) {
        Console.Write("Enter total chocolates: ");
        int totalChocolates = int.Parse(Console.ReadLine());
        Console.Write("Enter number of children: ");
        int children = int.Parse(Console.ReadLine());

        int chocolatesPerChild = totalChocolates / children;
        int remainingChocolates = totalChocolates % children;

        Console.WriteLine("Each child gets {0} chocolates. Remaining chocolates: {1}", chocolatesPerChild, remainingChocolates);
    }
}
