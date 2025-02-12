using System;

public class Task
{
    public int taskId;
    public string taskName;
    public int priority;
    public DateTime dueDate;
    public Task next;

    public Task()
    {
        this.taskId = 0;
        this.taskName = "";
        this.priority = 0;
        this.dueDate = DateTime.Now;
        this.next = null;
    }

    public Task(int taskId, string taskName, int priority, DateTime dueDate)
    {
        this.taskId = taskId;
        this.taskName = taskName;
        this.priority = priority;
        this.dueDate = dueDate;
        this.next = null;
    }
}

public class TaskList
{
    private Task head;
    private Task tail;

    public void AddTaskAtBeginning(Task newTask)
    {
        if (head == null)
        {
            head = newTask;
            tail = newTask;
            tail.next = head;
        }
        else
        {
            newTask.next = head;
            head = newTask;
            tail.next = head;
        }
        Console.WriteLine("Task added successfully");
    }

    public void AddTaskAtEnd(Task newTask)
    {
        if (head == null)
        {
            head = newTask;
            tail = newTask;
            tail.next = head;
        }
        else
        {
            tail.next = newTask;
            tail = newTask;
            tail.next = head;
        }
        Console.WriteLine("Task added successfully");
    }

    public void AddTaskAtPosition(Task newTask, int position)
    {
        if (position == 1)
        {
            AddTaskAtBeginning(newTask);
        }
        else
        {
            Task temp = head;
            for (int i = 1; i < position - 1; i++)
            {
                temp = temp.next;
            }
            newTask.next = temp.next;
            temp.next = newTask;
            Console.WriteLine("Task added successfully");
        }
    }

    public void DeleteTaskByTaskId(int taskId)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
        }
        else if (head.taskId == taskId)
        {
            head = head.next;
            tail.next = head;
        }
        else
        {
            Task temp = head;
            while (temp.next != head && temp.next.taskId != taskId)
            {
                temp = temp.next;
            }
            if (temp.next == head)
            {
                Console.WriteLine("Task not found");
            }
            else
            {
                temp.next = temp.next.next;
                Console.WriteLine("Task deleted successfully");
            }
        }
    }

    public void ViewCurrentTaskMoveToNextTask(int taskId)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
        }
        else if (head.taskId == taskId)
        {
            Console.WriteLine("Current Task: " + head.taskName);
            head = head.next;
            Console.WriteLine("Next Task: " + head.taskName);
        }
        else
        {
            Task temp = head;
            while (temp.next != head && temp.taskId != taskId)
            {
                temp = temp.next;
            }
            if (temp.next == head)
            {
                Console.WriteLine("Task not found");
            }
            else
            {
                Console.WriteLine("Current Task: " + temp.taskName);
                temp = temp.next;
                Console.WriteLine("Next Task: " + temp.taskName);
            }
        }
    }

    public void ViewAllTasks()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
        }
        else
        {
            Task temp = head;
            do
            {
                Console.WriteLine("Task ID: " + temp.taskId);
                Console.WriteLine("Task Name: " + temp.taskName);
                Console.WriteLine("Priority: " + temp.priority);
                Console.WriteLine("Due Date: " + temp.dueDate);
                Console.WriteLine();
                temp = temp.next;
            } while (temp != head);
        }
    }

    public void SearchForTaskByPriority(int priority)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
        }
        else
        {
            Task temp = head;
            do
            {
                if (temp.priority == priority)
                {
                    Console.WriteLine("Task ID: " + temp.taskId);
                    Console.WriteLine("Task Name: " + temp.taskName);
                    Console.WriteLine("Priority: " + temp.priority);
                    Console.WriteLine("Due Date: " + temp.dueDate);
                    Console.WriteLine();
                }
                temp = temp.next;
            } while (temp != head);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Task task1 = new Task(1, "Task 1", 1, new DateTime(2021, 12, 31));
        Task task2 = new Task(2, "Task 2", 2, new DateTime(2021, 12, 30));
        Task task3 = new Task(3, "Task 3", 3, new DateTime(2021, 12, 29));
        Task task4 = new Task(4, "Task 4", 4, new DateTime(2021, 12, 28));
        Task task5 = new Task(5, "Task 5", 5, new DateTime(2021, 12, 27));

        TaskList taskList = new TaskList();

        taskList.AddTaskAtBeginning(task1);
        taskList.AddTaskAtEnd(task2);
        taskList.AddTaskAtPosition(task3, 2);
        taskList.AddTaskAtPosition(task4, 4);
        taskList.AddTaskAtPosition(task5, 1);

        taskList.ViewAllTasks();

        taskList.DeleteTaskByTaskId(3);
        taskList.ViewAllTasks();

        taskList.ViewCurrentTaskMoveToNextTask(2);

        taskList.SearchForTaskByPriority(4);


    }
}

