using System;

namespace DateFormatting
{
    class DateTimeFormatting
    {
        public static void Main(string[] args)
        {
            // Get the current date
            DateTime currentDate = DateTime.Now;

            // Display the current date in dd/MM/yyyy format
            string format1 = currentDate.ToString("dd/MM/yyyy");
            Console.WriteLine("Current date in dd/MM/yyyy format: " + format1);

            // Display the current date in yyyy-MM-dd format
            string format2 = currentDate.ToString("yyyy-MM-dd");
            Console.WriteLine("Current date in yyyy-MM-dd format: " + format2);

            // Display the current date in EEE, MMM dd, yyyy format
            string format3 = currentDate.ToString("ddd, MMM dd, yyyy");
            Console.WriteLine("Current date in EEE, MMM dd, yyyy format: " + format3);
        }
    }
}