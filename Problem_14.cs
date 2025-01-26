
using System;

class BMICalculator
{
    public static void Main(string[] args)
    {
        // Input the number of persons
        Console.WriteLine("Enter the number of persons:");
        int numberOfPersons = Convert.ToInt32(Console.ReadLine());

        // Multi-dimensional array to store height, weight, and BMI
        double[][] personData = new double[numberOfPersons][];
        for (int i = 0; i < numberOfPersons; i++)
        {
            personData[i] = new double[3]; // 0 -> height, 1 -> weight, 2 -> BMI
        }

        // Array to store weight status
        string[] weightStatus = new string[numberOfPersons];

        // Input height and weight for each person
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine("Enter the height (in meters) of person " + (i + 1) + ":");
            personData[i][0] = Convert.ToDouble(Console.ReadLine());
            while (personData[i][0] <= 0)
            {
                Console.WriteLine("Height must be positive. Enter again:");
                personData[i][0] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Enter the weight (in kilograms) of person " + (i + 1) + ":");
            personData[i][1] = Convert.ToDouble(Console.ReadLine());
            while (personData[i][1] <= 0)
            {
                Console.WriteLine("Weight must be positive. Enter again:");
                personData[i][1] = Convert.ToDouble(Console.ReadLine());
            }
        }

        // Calculate BMI and determine weight status
        for (int i = 0; i < numberOfPersons; i++)
        {
            personData[i][2] = personData[i][1] / (personData[i][0] * personData[i][0]); // BMI formula

            // Determine weight status
            if (personData[i][2] <= 18.4)
            {
                weightStatus[i] = "Underweight";
            }
            else if (personData[i][2] >= 18.5 && personData[i][2] <= 24.9)
            {
                weightStatus[i] = "Normal";
            }
            else if (personData[i][2] >= 25.0 && personData[i][2] <= 39.9)
            {
                weightStatus[i] = "Overweight";
            }
            else
            {
                weightStatus[i] = "Obese";
            }
        }

        // Display the results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Height (m)\tWeight (kg)\tBMI\t\tStatus");

        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine(personData[i][0].ToString("0.00") + "\t\t" 
                            + personData[i][1].ToString("0.0") + "\t\t" 
                            + personData[i][2].ToString("0.00") + "\t\t" 
                            + weightStatus[i]);
        }
    }
}



