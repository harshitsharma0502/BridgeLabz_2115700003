using System;

class Student
{
    public int RollNumber;
    public string Name;
    public int Age;
    public string Grade;
    public Student Next;
}

class StudentList
{
    private Student head;

    public void AddStudentAtBeginning(int roll, string name, int age, string grade)
    {
        Student newStudent = new Student { RollNumber = roll, Name = name, Age = age, Grade = grade, Next = head };
        head = newStudent;
    }

    public void AddStudentAtEnd(int roll, string name, int age, string grade)
    {
        Student newStudent = new Student { RollNumber = roll, Name = name, Age = age, Grade = grade, Next = null };
        if (head == null)
        {
            head = newStudent;
            return;
        }
        Student temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newStudent;
    }

    public void DeleteStudent(int roll)
    {
        if (head == null) return;
        if (head.RollNumber == roll)
        {
            head = head.Next;
            return;
        }
        Student temp = head;
        while (temp.Next != null && temp.Next.RollNumber != roll)
        {
            temp = temp.Next;
        }
        if (temp.Next != null)
        {
            temp.Next = temp.Next.Next;
        }
    }

    public Student SearchStudent(int roll)
    {
        Student temp = head;
        while (temp != null)
        {
            if (temp.RollNumber == roll)
                return temp;
            temp = temp.Next;
        }
        return null;
    }

    public void Update2Grade(int roll, string newGrade)
    {
        Student student = SearchStudent(roll);
        if (student != null)
        {
            student.Grade = newGrade;
        }
    }

    public void DisplayStudents()
    {
        Student temp = head;
        while (temp != null)
        {
            Console.WriteLine("Roll No: " + temp.RollNumber + ", Name: " + temp.Name + ", Age: " + temp.Age + ", Grade: " + temp.Grade);
            temp = temp.Next;
        }
    }
}

class StudentManagement
{
    public static void Main(String[] args)
    {
        StudentList list = new StudentList();
        
        Console.WriteLine("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter Roll Number: ");
            int roll = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Grade: ");
            string grade = Console.ReadLine();
            
            list.AddStudentAtEnd(roll, name, age, grade);
        }
        
        list.DisplayStudents();
    }
}