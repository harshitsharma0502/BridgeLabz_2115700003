using System;

class BMICalculator
{
    public static void Main(string[] args)
    {
        // Input the number of persons
        Console.WriteLine("Enter the number of persons:");
        int numberOfPersons = Convert.ToInt32(Console.ReadLine());

        // Arrays to store height, weight, BMI, and status
        double[] heights = new double[numberOfPersons];
        double[] weights = new double[numberOfPersons];
        double[] bmis = new double[numberOfPersons];
        string[] statuses = new string[numberOfPersons];

        // Input height and weight for each person
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine("Enter the height (in meters) of person " + (i + 1) + ":");
            heights[i] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the weight (in kilograms) of person " + (i + 1) + ":");
            weights[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Calculate BMI and determine status
        for (int i = 0; i < numberOfPersons; i++)
        {
            bmis[i] = weights[i] / (heights[i] * heights[i]); // BMI formula

            // Determine weight status based on updated ranges
            if (bmis[i] <= 18.4)
            {
                statuses[i] = "Underweight";
            }
            else if (bmis[i] >= 18.5 && bmis[i] <= 24.9)
            {
                statuses[i] = "Normal";
            }
            else if (bmis[i] >= 25.0 && bmis[i] <= 39.9)
            {
                statuses[i] = "Overweight";
            }
            else
            {
                statuses[i] = "Obese";
            }
        }

        // Display the results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Height (m)\tWeight (kg)\tBMI\t\tStatus");

        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine(heights[i].ToString("0.00") + "\t\t" 
                            + weights[i].ToString("0.0") + "\t\t" 
                            + bmis[i].ToString("0.00") + "\t\t" 
                            + statuses[i]);
        }
    }
}
