using System;
public class Process
{
    public int processId;
    public int burstTime;
    public int remainingTime;
    public int priority;
    public Process next;

    public Process(int processId, int burstTime, int priority)
    {
        this.processId = processId;
        this.burstTime = burstTime;
        this.remainingTime = burstTime;
        this.priority = priority;
        this.next = null;
    }
}

public class RoundRobinScheduler
{
    private Process head = null;
    private Process tail = null;
    private int quantum;

    public RoundRobinScheduler(int timeQuantum)
    {
        this.quantum = timeQuantum;
    }

    public void AddProcess(int processId, int burstTime, int priority)
    {
        Process newProcess = new Process(processId, burstTime, priority);

        if (head == null)
        {
            head = tail = newProcess;
            tail.next = head;
        }
        else
        {
            tail.next = newProcess;
            tail = newProcess;
            tail.next = head;
        }

        Console.WriteLine($"Process {processId} added successfully.");
    }

    public void RemoveProcess(int processId)
    {
        if (head == null)
        {
            Console.WriteLine("No processes in the queue.");
            return;
        }

        Process temp = head, prev = null;

        if (head.processId == processId)
        {
            if (head == tail)
            {
                head = tail = null;
            }
            else
            {
                head = head.next;
                tail.next = head;
            }
            Console.WriteLine($"Process {processId} removed after execution.");
            return;
        }

        do
        {
            prev = temp;
            temp = temp.next;

            if (temp.processId == processId)
            {
                prev.next = temp.next;
                if (temp == tail) tail = prev;
                Console.WriteLine($"Process {processId} removed after execution.");
                return;
            }
        } while (temp != head);

        Console.WriteLine($"Process {processId} not found.");
    }

    public void DisplayProcesses()
    {
        if (head == null)
        {
            Console.WriteLine("No processes in the queue.");
            return;
        }

        Process temp = head;
        Console.WriteLine("Current Process Queue:");
        do
        {
            Console.WriteLine($"Process ID: {temp.processId}, Remaining Time: {temp.remainingTime}, Priority: {temp.priority}");
            temp = temp.next;
        } while (temp != head);
    }

    public void SimulateRoundRobin()
    {
        if (head == null)
        {
            Console.WriteLine("No processes to execute.");
            return;
        }

        int totalTime = 0;
        int processCount = 0;
        int totalWaitingTime = 0;
        int totalTurnaroundTime = 0;

        Console.WriteLine("\nStarting Round Robin Scheduling...");

        while (head != null)
        {
            Process temp = head;
            do
            {
                if (temp.remainingTime > 0)
                {
                    int executionTime = Math.Min(quantum, temp.remainingTime);
                    temp.remainingTime -= executionTime;
                    totalTime += executionTime;

                    if (temp.remainingTime == 0)
                    {
                        int turnaroundTime = totalTime;
                        int waitingTime = turnaroundTime - temp.burstTime;
                        totalWaitingTime += waitingTime;
                        totalTurnaroundTime += turnaroundTime;
                        processCount++;

                        int processIdToRemove = temp.processId;
                        temp = temp.next;
                        RemoveProcess(processIdToRemove);
                    }
                    else
                    {
                        temp = temp.next;
                    }

                    DisplayProcesses();
                }
            } while (temp != head && head != null);
        }

        if (processCount > 0)
        {
            double avgWaitingTime = (double)totalWaitingTime / processCount;
            double avgTurnaroundTime = (double)totalTurnaroundTime / processCount;
            Console.WriteLine($"\nAverage Waiting Time: {avgWaitingTime:F2}");
            Console.WriteLine($"Average Turnaround Time: {avgTurnaroundTime:F2}");
        }
    }
}

class Program
{
    static void Main()
    {
        RoundRobinScheduler scheduler = new RoundRobinScheduler(3);

        scheduler.AddProcess(1, 10, 2);
        scheduler.AddProcess(2, 4, 1);
        scheduler.AddProcess(3, 7, 3);
        scheduler.AddProcess(4, 6, 2);

        scheduler.DisplayProcesses();

        scheduler.SimulateRoundRobin();
    }
}
