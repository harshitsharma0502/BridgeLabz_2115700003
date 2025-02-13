using System;
using System.Collections.Generic;
public class Queue
{
    Stack<int> stack1 = new Stack<int>();
    Stack<int> stack2 = new Stack<int>();

    public void Enqueue(int x)
    {
        if (stack1.Count == 0)
        {
            stack1.Push(x);
        }
        else
        {
            while (stack1.Count != 0)
            {
                stack2.Push(stack1.Pop());
            }
            stack1.Push(x);

            while (stack2.Count != 0)
            {
                stack1.Push(stack2.Pop());
            }
        }
    }
    public void Dequeue()
    {
        if (stack1.Count != 0)
        {
            stack1.Pop();
        }
        else
        {
            Console.WriteLine("Queue is empty");
        }
    }
    public int Front()
    {
        if (stack1.Count != 0)
        {
            return stack1.Peek();
        }
        else
        {
            Console.WriteLine("Queue is empty");
            return -1;
        }
    }
    public bool IsEmpty()
    {
        return stack1.Count == 0;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Queue q = new Queue();

        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);
        q.Enqueue(4);

        Console.WriteLine("Front element: " + q.Front());
        q.Dequeue();

        Console.WriteLine("Elements of queue");
        while (!q.IsEmpty())
        {
            Console.Write(q.Front() + " ");
            q.Dequeue();
        }
    }
}