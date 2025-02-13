using System;
using System.Collections.Generic;

class StockSpanProblem
{
    static int[] CalculateStockSpan(int[] prices)
    {
        int n = prices.Length;
        int[] span = new int[n];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
            {
                stack.Pop();
            }
            span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());
            stack.Push(i);
        }
        return span;
    }

    static void Main()
    {
        Console.Write("Enter the number of stock prices: ");
        int n = int.Parse(Console.ReadLine());
        int[] prices = new int[n];

        Console.WriteLine("Enter the stock prices:");
        for (int i = 0; i < n; i++)
        {
            prices[i] = int.Parse(Console.ReadLine());
        }

        int[] result = CalculateStockSpan(prices);

        Console.WriteLine("Stock Prices: " + string.Join(", ", prices));
        Console.WriteLine("Stock Span: " + string.Join(", ", result));
    }
}
