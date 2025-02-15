using System;
using System.Text;

class CompareStringPerformance
{
    static void Main()
    {
        // Ask user for the number of concatenations
        Console.Write("Enter the number of times to concatenate: ");
        int count = Convert.ToInt32(Console.ReadLine());

        // Measure time for normal string concatenation using DateTime
        DateTime startTime1 = DateTime.Now;
        string normalString = "";

        for (int i = 0; i < count; i++)
        {
            normalString += "X"; // Concatenation using "+"
        }

        DateTime endTime1 = DateTime.Now;
        TimeSpan duration1 = endTime1 - startTime1;
        Console.WriteLine("Time taken using string concatenation (+): " + duration1.TotalMilliseconds + " ms");

        // Measure time for StringBuilder concatenation using DateTime
        DateTime startTime2 = DateTime.Now;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            sb.Append("X"); // Concatenation using StringBuilder
        }

        DateTime endTime2 = DateTime.Now;
        TimeSpan duration2 = endTime2 - startTime2;
        Console.WriteLine("Time taken using StringBuilder Append(): " + duration2.TotalMilliseconds + " ms");
    }
}
