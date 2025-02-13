using System;
using System.Collections.Generic;

class Program
{
    static void InsertInSortedStack(Stack<int> stack, int num)
    {
        if (stack.Count == 0 || stack.Peek() <= num)
        {
            stack.Push(num);
            return;
        }
        int temp = stack.Pop();
        InsertInSortedStack(stack, num);
        stack.Push(temp);
    }

    static void SortStack(Stack<int> stack)
    {
        if (stack.Count == 0)
        {
            return;
        }
        int temp = stack.Pop();
        SortStack(stack);
        InsertInSortedStack(stack, temp);
    }

    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(12);
        stack.Push(23);
        stack.Push(5);
        stack.Push(14);

        SortStack(stack);

        while (stack.Count > 0)
        {
            Console.Write(stack.Pop() + " ");
        }
    }
}
