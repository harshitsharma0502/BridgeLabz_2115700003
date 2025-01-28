using System;

class LeapYear
{
    public static void Main(string[] args)
    {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            if (year < 1582)
            {
                Console.WriteLine("The year must be greater than or equal to 1582 (Gregorian calendar).");
            }
            else
            {
                if (year % 4 == 0)
                {
                    if (year % 100 == 0)
                    {
                        if (year % 400 == 0)
                        {
                            Console.WriteLine(year +" is a Leap Year.");
                        }
                        else
                        {
                            Console.WriteLine(year+" is not a Leap Year.");
                        }
                    }
                    else
                    {
                        Console.WriteLine(year+" is a Leap Year.");
                    }
                }
                else
                {
                    Console.WriteLine(year+" is not a Leap Year.");
                }
            }
        }
    }